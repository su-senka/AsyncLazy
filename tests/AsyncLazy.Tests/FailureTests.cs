using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>Only success is kept</summary>
    public sealed class FailureTests
    {
        [Fact]
        public async Task All_waiters_of_a_faulted_attempt_receive_the_same_exception_unwrapped()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            Task<int> first = lazy.GetValueAsync();
            Task<int> second = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            var failure = new TestException();
            factory.Attempt(0).SetException(failure);

            Assert.Same(failure, await Assert.ThrowsAsync<TestException>(() => first.WithTimeout()));
            Assert.Same(failure, await Assert.ThrowsAsync<TestException>(() => second.WithTimeout()));
        }

        [Fact]
        public async Task A_call_after_a_failed_attempt_starts_a_new_attempt()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            await FailFirstAttempt(lazy, factory);

            _ = lazy.GetValueAsync();
            await factory.StartedAsync(1);

            Assert.Equal(2, factory.Calls);
        }

        [Fact]
        public async Task Success_after_an_earlier_failure_is_kept()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            await FailFirstAttempt(lazy, factory);

            Task<int> retry = lazy.GetValueAsync();
            await factory.StartedAsync(1);
            factory.Attempt(1).SetResult(5);

            Assert.Equal(5, await retry.WithTimeout());
            Assert.Equal(5, await lazy.GetValueAsync().WithTimeout());
            Assert.Equal(2, factory.Calls);
        }

        [Fact]
        public async Task A_factory_that_throws_synchronously_is_treated_like_a_faulted_task()
        {
            int calls = 0;
            var failure = new TestException();
            var lazy = new AsyncLazy<int>(() =>
            {
                if (Interlocked.Increment(ref calls) == 1) throw failure;
                return Task.FromResult(9);
            });

            Assert.Same(failure, await Assert.ThrowsAsync<TestException>(() => lazy.GetValueAsync().WithTimeout()));
            Assert.Equal(9, await lazy.GetValueAsync().WithTimeout());
            Assert.Equal(2, calls);
        }

        [Fact]
        public async Task A_factory_that_returns_a_null_task_fails_and_is_retried()
        {
            int calls = 0;
            var lazy = new AsyncLazy<int>(() => Interlocked.Increment(ref calls) == 1 ? null! : Task.FromResult(3));

            await Assert.ThrowsAsync<InvalidOperationException>(() => lazy.GetValueAsync().WithTimeout());
            Assert.Equal(3, await lazy.GetValueAsync().WithTimeout());
            Assert.Equal(2, calls);
        }

        [Fact]
        public async Task Waiters_of_a_failed_attempt_receive_its_failure_and_are_not_retried()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            Task<int> waiterA = lazy.GetValueAsync();
            Task<int> waiterB = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            var failure = new TestException();
            factory.Attempt(0).SetException(failure);

            // Both waiters complete with attempt 0's failure without a new attempt being started on their behalf.
            Assert.Same(failure, await Assert.ThrowsAsync<TestException>(() => waiterA.WithTimeout()));
            Assert.Same(failure, await Assert.ThrowsAsync<TestException>(() => waiterB.WithTimeout()));
            await TestExtensions.Settle();
            Assert.Equal(1, factory.Calls);

            // Only a new call starts the next attempt.
            Task<int> retry = lazy.GetValueAsync();
            await factory.StartedAsync(1);
            Assert.False(retry.IsCompleted);
        }

        [Fact]
        public async Task Only_one_retry_starts_after_a_failure_stress()
        {
            const int Iterations = 20, Callers = 64;
            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                int calls = 0;
                var lazy = new AsyncLazy<int>(async () =>
                {
                    int call = Interlocked.Increment(ref calls);
                    await Task.Yield();
                    return call == 1 ? throw new TestException() : 11;
                });
                await Assert.ThrowsAsync<TestException>(() => lazy.GetValueAsync().WithTimeout());
                using var start = new ManualResetEventSlim();

                Task<int>[] callers = Enumerable.Range(0, Callers)
                    .Select(_ => Task.Factory.StartNew(() =>
                    {
                        start.Wait();
                        return lazy.GetValueAsync();
                    }, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default).Unwrap())
                    .ToArray();
                start.Set();
                int[] values = await Task.WhenAll(callers).WithTimeout();

                Assert.Equal(2, calls);
                Assert.All(values, v => Assert.Equal(11, v));
            }
        }

        [Fact]
        public async Task A_factory_that_cancels_itself_is_treated_as_a_failure()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            Task<int> first = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            factory.Attempt(0).SetCanceled();

            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => first.WithTimeout());
            Task<int> retry = lazy.GetValueAsync();
            await factory.StartedAsync(1);
            factory.Attempt(1).SetResult(1);
            Assert.Equal(1, await retry.WithTimeout());
            Assert.Equal(2, factory.Calls);
        }

        [Fact]
        public async Task State_after_a_failure_reports_no_value()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            await FailFirstAttempt(lazy, factory);

            Assert.False(lazy.IsValueCreated);
            Assert.False(lazy.TryGetValue(out _));
        }

        private static async Task FailFirstAttempt(AsyncLazy<int> lazy, ControlledFactory<int> factory)
        {
            Task<int> first = lazy.GetValueAsync();
            await factory.StartedAsync(0);
            factory.Attempt(0).SetException(new TestException());
            await Assert.ThrowsAsync<TestException>(() => first.WithTimeout());
        }
    }
}
