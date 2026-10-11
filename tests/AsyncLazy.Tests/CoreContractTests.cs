using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>One shared value, no blocking</summary>
    public sealed class CoreContractTests
    {
        [Fact]
        public async Task First_call_starts_the_factory()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);

            Task<int> value = lazy.GetValueAsync();
            await factory.StartedAsync(0);
            factory.Attempt(0).SetResult(42);

            Assert.Equal(42, await value.WithTimeout());
            Assert.Equal(1, factory.Calls);
        }

        [Fact]
        public async Task Calls_after_success_return_the_value_without_running_the_factory_again()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            Task<int> first = lazy.GetValueAsync();
            await factory.StartedAsync(0);
            factory.Attempt(0).SetResult(42);
            await first.WithTimeout();

            for (int i = 0; i < 3; i++)
                Assert.Equal(42, await lazy.GetValueAsync().WithTimeout());

            Assert.Equal(1, factory.Calls);
        }

        [Fact]
        public async Task Calls_after_success_return_the_same_task_instance()
        {
            var lazy = new AsyncLazy<int>(() => Task.FromResult(42));
            await lazy.GetValueAsync().WithTimeout();

            Assert.Same(lazy.GetValueAsync(), lazy.GetValueAsync());

            var preinitialized = new AsyncLazy<int>(7);
            Assert.Same(preinitialized.GetValueAsync(), preinitialized.GetValueAsync());
        }

        [Fact]
        public async Task Calls_after_success_with_a_cancelable_token_return_the_value()
        {
            var lazy = new AsyncLazy<int>(() => Task.FromResult(42));
            await lazy.GetValueAsync().WithTimeout();
            using var cts = new CancellationTokenSource();

            Task<int> value = lazy.GetValueAsync(cts.Token);

            Assert.True(value.IsCompletedSuccessfully);
            Assert.Equal(42, await value);
        }

        [Fact]
        public async Task Concurrent_first_calls_share_one_attempt_stress()
        {
            const int Iterations = 20, Callers = 64;
            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                int calls = 0;
                var lazy = new AsyncLazy<int>(async () =>
                {
                    Interlocked.Increment(ref calls);
                    await Task.Yield();
                    return 7;
                });
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

                Assert.Equal(1, calls);
                Assert.All(values, v => Assert.Equal(7, v));
            }
        }

        [Fact]
        public async Task Callers_arriving_during_an_attempt_join_it()
        {
            var factory = new ControlledFactory<int>();
            var lazy = new AsyncLazy<int>(factory.Invoke);
            Task<int> first = lazy.GetValueAsync();
            await factory.StartedAsync(0);

            Task<int> late = lazy.GetValueAsync();
            Assert.False(late.IsCompleted);
            factory.Attempt(0).SetResult(42);

            Assert.Equal(42, await first.WithTimeout());
            Assert.Equal(42, await late.WithTimeout());
            Assert.Equal(1, factory.Calls);
        }
    }
}
