using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>A factory awaiting its own value fails fast instead of hanging</summary>
    public sealed class RecursionTests
    {
        [Fact]
        public async Task A_factory_awaiting_its_own_value_throws_and_is_not_kept()
        {
            int calls = 0;
            AsyncLazy<int>? lazy = null;
            lazy = new AsyncLazy<int>(async () =>
            {
                Interlocked.Increment(ref calls);
                return await lazy!.GetValueAsync();
            });

            await Assert.ThrowsAsync<InvalidOperationException>(() => lazy.GetValueAsync().WithTimeout());
            await Assert.ThrowsAsync<InvalidOperationException>(() => lazy.GetValueAsync().WithTimeout());
            Assert.Equal(2, calls);
        }

        [Fact]
        public async Task A_cycle_through_two_instances_throws_instead_of_hanging()
        {
            AsyncLazy<int>? a = null, b = null;
            a = new AsyncLazy<int>(async () => await b!.GetValueAsync() + 1);
            b = new AsyncLazy<int>(async () => await a!.GetValueAsync() + 1);

            await Assert.ThrowsAsync<InvalidOperationException>(() => a.GetValueAsync().WithTimeout());
        }

        [Fact]
        public async Task A_factory_may_await_an_unrelated_instance()
        {
            var b = new AsyncLazy<int>(() => Task.FromResult(3));
            var a = new AsyncLazy<int>(async () => await b.GetValueAsync() + 1);

            Assert.Equal(4, await a.GetValueAsync().WithTimeout());
        }

        [Fact]
        public async Task Work_left_over_from_a_failed_attempt_waits_normally_during_the_next_attempt()
        {
            int calls = 0;
            Task<int>? leftover = null;
            TaskCompletionSource releaseLeftover = Gate.Create(), secondStarted = Gate.Create();
            TaskCompletionSource<int> secondResult = Gate.Create<int>();
            AsyncLazy<int>? lazy = null;
            lazy = new AsyncLazy<int>(async () =>
            {
                if (Interlocked.Increment(ref calls) == 1)
                {
                    // Started inside attempt 1, so it inherits attempt 1's execution context.
                    leftover = Task.Run(async () =>
                    {
                        await releaseLeftover.Task;
                        return await lazy!.GetValueAsync();
                    });
                    throw new TestException();
                }
                secondStarted.SetResult();
                return await secondResult.Task;
            });

            await Assert.ThrowsAsync<TestException>(() => lazy.GetValueAsync().WithTimeout());
            Task<int> retry = lazy.GetValueAsync();
            await secondStarted.Task.WithTimeout();
            releaseLeftover.SetResult();
            await TestExtensions.Settle();

            Assert.False(leftover!.IsCompleted, "Leftover work should wait on attempt 2, not fail as recursion.");
            secondResult.SetResult(10);
            Assert.Equal(10, await leftover.WithTimeout());
            Assert.Equal(10, await retry.WithTimeout());
        }

        [Fact]
        public async Task Work_started_by_the_factory_can_read_the_value_after_success()
        {
            Task<int>? background = null;
            TaskCompletionSource releaseBackground = Gate.Create();
            AsyncLazy<int>? lazy = null;
            lazy = new AsyncLazy<int>(() =>
            {
                background = Task.Run(async () =>
                {
                    await releaseBackground.Task;
                    return await lazy!.GetValueAsync();
                });
                return Task.FromResult(1);
            });

            Assert.Equal(1, await lazy.GetValueAsync().WithTimeout());
            releaseBackground.SetResult();

            Assert.Equal(1, await background!.WithTimeout());
        }

        [Fact]
        public async Task Work_the_factory_starts_without_awaiting_is_part_of_the_attempt()
        {
            // Known trade-off of flow-based detection: this work could have waited safely, because the
            // factory doesn't wait on it, but it carries the attempt's execution context.
            Task<int>? fork = null;
            TaskCompletionSource forkStarted = Gate.Create(), release = Gate.Create();
            AsyncLazy<int>? lazy = null;
            lazy = new AsyncLazy<int>(async () =>
            {
                fork = Task.Run(() => lazy!.GetValueAsync());
                forkStarted.SetResult();
                await release.Task;
                return 1;
            });

            Task<int> first = lazy.GetValueAsync();
            await forkStarted.Task.WithTimeout();

            await Assert.ThrowsAsync<InvalidOperationException>(() => fork!.WithTimeout());
            release.SetResult();
            Assert.Equal(1, await first.WithTimeout());
        }

        [Fact]
        public async Task Work_started_with_execution_context_flow_suppressed_waits_normally()
        {
            Task<int>? fork = null;
            TaskCompletionSource forkStarted = Gate.Create(), release = Gate.Create();
            AsyncLazy<int>? lazy = null;
            lazy = new AsyncLazy<int>(async () =>
            {
                using (ExecutionContext.SuppressFlow())
                {
                    fork = Task.Run(() => lazy!.GetValueAsync());
                }

                forkStarted.SetResult();
                await release.Task;
                return 1;
            });

            Task<int> first = lazy.GetValueAsync();
            await forkStarted.Task.WithTimeout();
            await TestExtensions.Settle();

            Assert.False(fork!.IsCompleted, "Work started without the attempt's context should wait, not fail.");
            release.SetResult();
            Assert.Equal(1, await fork.WithTimeout());
            Assert.Equal(1, await first.WithTimeout());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task Work_that_outlives_the_attempt_does_not_keep_the_instance_alive_gc(bool succeed)
        {
            Gc.SkipUnlessCollectionIsReliable();

            // Stands in for anything long-lived the factory starts: a timer, a connection, a background loop.
            // Each keeps the execution context it was started with.
            var captured = new StrongBox<ExecutionContext?>();
            WeakReference instance = RunAndDrop(captured, succeed);

            // The attempt finishes processing its outcome on another thread a moment after waiters are released.
            for (int i = 0; i < 100 && instance.IsAlive; i++)
            {
                Gc.Collect();
                await Task.Delay(10, TestContext.Current.CancellationToken);
            }

            Assert.NotNull(captured.Value);
            Assert.False(instance.IsAlive, "A context captured inside the factory should not keep the instance alive.");
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static WeakReference RunAndDrop(StrongBox<ExecutionContext?> captured, bool succeed)
        {
            var lazy = new AsyncLazy<byte[]>(async () =>
            {
                await Task.Yield();
                captured.Value = ExecutionContext.Capture();
                return succeed ? new byte[1024] : throw new TestException();
            });

            try
            {
                lazy.GetValueAsync().WithTimeout().GetAwaiter().GetResult();
            }
            catch (TestException)
            {
            }

            return new WeakReference(lazy);
        }

        [Fact]
        public async Task The_recursion_error_is_reported_through_the_task_not_thrown()
        {
            // A synchronous throw would escape from callbacks that start the call without awaiting it
            // (timers, event handlers, cancellation callbacks) and could terminate the process.
            Exception? thrown = null;
            Task<int>? fromInside = null;
            AsyncLazy<int>? lazy = null;
            lazy = new AsyncLazy<int>(async () =>
            {
                try
                {
                    fromInside = lazy!.GetValueAsync();
                }
                catch (Exception e)
                {
                    thrown = e;
                }

                await Task.Yield();
                return 1;
            });

            Assert.Equal(1, await lazy.GetValueAsync().WithTimeout());

            Assert.Null(thrown);
            Assert.NotNull(fromInside);
            await Assert.ThrowsAsync<InvalidOperationException>(() => fromInside.WithTimeout());
        }
    }
}
