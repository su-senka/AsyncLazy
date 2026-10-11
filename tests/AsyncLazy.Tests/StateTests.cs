using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>State inspection</summary>
    public sealed class StateTests
    {
        [Fact]
        public async Task IsValueCreated_is_true_only_after_success()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            Assert.False(lazy.IsValueCreated);

            Task<int> value = lazy.GetValueAsync();
            await factory.StartedAsync(0);
            Assert.False(lazy.IsValueCreated);

            factory.Attempt(0).SetResult(1);
            await value.WithTimeout();
            Assert.True(lazy.IsValueCreated);
        }

        [Fact]
        public async Task TryGetValue_never_starts_an_attempt()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);

            Assert.False(lazy.TryGetValue(out int value));
            Assert.Equal(default, value);
            await TestExtensions.Settle();
            Assert.Equal(0, factory.Calls);
        }

        [Fact]
        public async Task TryGetValue_after_success_returns_the_value()
        {
            var lazy = new AsyncLazy<int>(() => Task.FromResult(42));
            await lazy.GetValueAsync().WithTimeout();

            Assert.True(lazy.TryGetValue(out int value));
            Assert.Equal(42, value);
        }

        [Fact]
        public async Task TryGetValue_while_an_attempt_is_running_returns_false_without_waiting()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            _ = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            Assert.False(lazy.TryGetValue(out _));
        }

        [Fact]
        public async Task The_factory_is_released_after_success_gc()
        {
            Gc.SkipUnlessCollectionIsReliable();
            (AsyncLazy<int> lazy, WeakReference capturedState) = CreateWithCapturedState();

            await lazy.GetValueAsync().WithTimeout();
            Gc.Collect();

            Assert.False(capturedState.IsAlive, "State captured by the factory should be collectible once the value exists.");
            GC.KeepAlive(lazy);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static (AsyncLazy<int>, WeakReference) CreateWithCapturedState()
        {
            byte[] state = new byte[1024];
            return (new AsyncLazy<int>(() => Task.FromResult(state.Length)), new WeakReference(state));
        }
    }
}
