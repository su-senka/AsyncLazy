using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>Lifetime token: owned by whoever created the instance</summary>
    public sealed class LifetimeTests
    {
        [Fact]
        public async Task The_factory_receives_the_lifetime_token_never_a_callers()
        {
            var factory = new ControlledFactory<int>();
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(factory.Invoke, lifetime.Token);
            using var caller = new CancellationTokenSource();

            _ = lazy.GetValueAsync(caller.Token);
            CancellationToken received = await factory.StartedAsync(0);

            Assert.Equal(lifetime.Token, received);
            Assert.NotEqual(caller.Token, received);
        }

        [Fact]
        public async Task Canceling_the_lifetime_during_an_attempt_cancels_its_waiters()
        {
            var factory = new ControlledFactory<int>();
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(factory.Invoke, lifetime.Token);
            Task<int> wait = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            lifetime.Cancel();

            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => wait.WithTimeout());
        }

        [Fact]
        public async Task No_new_attempts_start_after_the_lifetime_is_canceled()
        {
            var factory = new ControlledFactory<int>();
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(factory.Invoke, lifetime.Token);
            Task<int> wait = lazy.GetValueAsync();
            await factory.StartedAsync(0);
            lifetime.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => wait.WithTimeout());

            Task<int> after = lazy.GetValueAsync();

            Assert.True(after.IsCanceled);
            await TestExtensions.Settle();
            Assert.Equal(1, factory.Calls);
        }

        [Fact]
        public async Task A_lifetime_canceled_at_construction_never_runs_the_factory()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke, new CancellationToken(canceled: true));

            Task<int> wait = lazy.GetValueAsync();

            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => wait.WithTimeout());
            await TestExtensions.Settle();
            Assert.Equal(0, factory.Calls);
        }

        [Fact]
        public async Task Canceling_the_lifetime_after_success_has_no_effect()
        {
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(_ => Task.FromResult(42), lifetime.Token);
            await lazy.GetValueAsync().WithTimeout();

            lifetime.Cancel();

            Assert.Equal(42, await lazy.GetValueAsync().WithTimeout());
            Assert.True(lazy.IsValueCreated);
        }

        [Fact]
        public async Task CancellationToken_None_as_lifetime_behaves_like_the_tokenless_constructor()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke, CancellationToken.None);

            Task<int> first = lazy.GetValueAsync();
            CancellationToken received = await factory.StartedAsync(0);
            Assert.False(received.CanBeCanceled);
            factory.Attempt(0).SetException(new TestException());
            await Assert.ThrowsAsync<TestException>(() => first.WithTimeout());

            Task<int> retry = lazy.GetValueAsync();
            await factory.StartedAsync(1);
            factory.Attempt(1).SetResult(8);
            Assert.Equal(8, await retry.WithTimeout());
        }

        // The factory below ignores the lifetime token, which is also how a factory that observes it slowly looks while it unwinds

        [Fact]
        public async Task Waiters_wait_for_a_factory_that_ignores_the_lifetime_token()
        {
            var factory = new ControlledFactory<int>();
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(_ => factory.Invoke(), lifetime.Token);
            Task<int> wait = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            lifetime.Cancel();
            await TestExtensions.Settle();

            Assert.False(wait.IsCompleted, "Waiters wait for the work; they are not released on the owner's behalf.");
            factory.Attempt(0).SetResult(7);
            Assert.Equal(7, await wait.WithTimeout());
        }

        [Fact]
        public async Task After_lifetime_cancellation_a_call_joins_the_running_attempt_and_its_late_value_is_kept()
        {
            var factory = new ControlledFactory<int>();
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(_ => factory.Invoke(), lifetime.Token);
            _ = lazy.GetValueAsync();
            await factory.StartedAsync(0);
            lifetime.Cancel();

            // How an owner reaches a value produced after shutdown, to dispose of it.
            Task<int> late = lazy.GetValueAsync();
            await TestExtensions.Settle();
            Assert.False(late.IsCompleted);
            factory.Attempt(0).SetResult(7);

            Assert.Equal(7, await late.WithTimeout());
            Assert.True(lazy.IsValueCreated);
            Assert.Equal(7, await lazy.GetValueAsync().WithTimeout());
            Assert.Equal(1, factory.Calls);
        }

        [Fact]
        public async Task A_failure_after_lifetime_cancellation_reaches_waiters_unchanged()
        {
            var factory = new ControlledFactory<int>();
            using var lifetime = new CancellationTokenSource();
            var lazy = new AsyncLazy<int>(_ => factory.Invoke(), lifetime.Token);
            Task<int> wait = lazy.GetValueAsync();
            await factory.StartedAsync(0);
            lifetime.Cancel();

            // Typical shutdown race: the owner disposed a dependency the factory was still using.
            factory.Attempt(0).SetException(new ObjectDisposedException("dependency"));

            await Assert.ThrowsAsync<ObjectDisposedException>(() => wait.WithTimeout());
            Assert.True(lazy.GetValueAsync().IsCanceled);
            Assert.Equal(1, factory.Calls);
        }
    }
}
