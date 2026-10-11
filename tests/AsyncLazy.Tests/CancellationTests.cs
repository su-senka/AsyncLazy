using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>A caller's token cancels only that caller's wait</summary>
    public sealed class CancellationTests
    {
        [Fact]
        public async Task A_waiting_caller_that_cancels_receives_its_own_cancellation()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            using var caller = new CancellationTokenSource();
            Task<int> wait = lazy.GetValueAsync(caller.Token);
            await factory.StartedAsync(0);

            caller.Cancel();

            var canceled = await Assert.ThrowsAnyAsync<OperationCanceledException>(() => wait.WithTimeout());
            Assert.Equal(caller.Token, canceled.CancellationToken);
        }

        [Fact]
        public async Task Other_waiters_are_unaffected_by_one_caller_canceling()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            using var caller = new CancellationTokenSource();
            Task<int> canceledWait = lazy.GetValueAsync(caller.Token);
            Task<int> otherWait = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            caller.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => canceledWait.WithTimeout());
            factory.Attempt(0).SetResult(42);

            Assert.Equal(42, await otherWait.WithTimeout());
        }

        [Fact]
        public async Task The_attempt_keeps_running_after_a_caller_cancels()
        {
            var factory = new ControlledFactory<int>();
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(factory.Invoke, lifetime.Token);
            using var caller = new CancellationTokenSource();
            Task<int> wait = lazy.GetValueAsync(caller.Token);
            CancellationToken factoryToken = await factory.StartedAsync(0);

            caller.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => wait.WithTimeout());

            Assert.False(factoryToken.IsCancellationRequested);
            Task<int> later = lazy.GetValueAsync();
            factory.Attempt(0).SetResult(42);
            Assert.Equal(42, await later.WithTimeout());
            Assert.Equal(1, factory.Calls);
        }

        [Fact]
        public async Task The_attempt_completes_and_is_kept_even_if_every_waiter_cancels()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            using var callerA = new CancellationTokenSource();
            using var callerB = new CancellationTokenSource();
            Task<int> waitA = lazy.GetValueAsync(callerA.Token);
            Task<int> waitB = lazy.GetValueAsync(callerB.Token);
            await factory.StartedAsync(0);

            callerA.Cancel();
            callerB.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => waitA.WithTimeout());
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => waitB.WithTimeout());
            factory.Attempt(0).SetResult(42);

            Assert.Equal(42, await lazy.GetValueAsync().WithTimeout());
            Assert.True(lazy.IsValueCreated);
            Assert.Equal(1, factory.Calls);
        }

        [Fact]
        public async Task Timeouts_shorter_than_initialization_do_not_starve_the_value()
        {
            // Every caller gives up before initialization finishes. If giving up canceled the shared
            // work, the value would never be produced. Here it is produced, once.
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);

            using (var timeout1 = new CancellationTokenSource())
            {
                Task<int> caller1 = lazy.GetValueAsync(timeout1.Token);
                await factory.StartedAsync(0);
                timeout1.Cancel();
                await Assert.ThrowsAnyAsync<OperationCanceledException>(() => caller1.WithTimeout());
            }
            using (var timeout2 = new CancellationTokenSource())
            {
                Task<int> caller2 = lazy.GetValueAsync(timeout2.Token);
                timeout2.Cancel();
                await Assert.ThrowsAnyAsync<OperationCanceledException>(() => caller2.WithTimeout());
            }

            Task<int> caller3 = lazy.GetValueAsync();
            factory.Attempt(0).SetResult(42);

            Assert.Equal(42, await caller3.WithTimeout());
            Assert.Equal(1, factory.Calls);
        }

        [Fact]
        public async Task An_already_canceled_token_does_not_start_an_attempt()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);

            Task<int> wait = lazy.GetValueAsync(new CancellationToken(canceled: true));

            Assert.True(wait.IsCanceled);
            await TestExtensions.Settle();
            Assert.Equal(0, factory.Calls);
        }

        [Fact]
        public async Task An_already_canceled_token_is_honored_even_when_the_value_exists()
        {
            var lazy = new AsyncLazy<int>(() => Task.FromResult(42));
            await lazy.GetValueAsync().WithTimeout();

            Task<int> wait = lazy.GetValueAsync(new CancellationToken(canceled: true));

            Assert.True(wait.IsCanceled);
        }
    }
}
