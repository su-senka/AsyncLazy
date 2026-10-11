using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>The factory always runs on the thread pool</summary>
    public sealed class ExecutionTests
    {
        [Fact]
        public async Task The_factory_does_not_see_the_callers_SynchronizationContext()
        {
            var observed = Gate.Create<StrongBox<SynchronizationContext?>>();
            var lazy = new AsyncLazy<int>(() =>
            {
                observed.TrySetResult(new(SynchronizationContext.Current));
                return Task.FromResult(1);
            });

            Task<int> value = await DedicatedThread.Run(new QueueingSynchronizationContext(), () => lazy.GetValueAsync()).WithTimeout();

            Assert.Null((await observed.Task.WithTimeout()).Value);
            Assert.Equal(1, await value.WithTimeout());
        }

        [Fact]
        public async Task Slow_synchronous_work_in_the_factory_does_not_block_the_caller()
        {
            using var release = new ManualResetEventSlim();
            var lazy = new AsyncLazy<int>(() =>
            {
                release.Wait(TestExtensions.Timeout);
                return Task.FromResult(1);
            });

            try
            {
                Task<Task<int>> call = DedicatedThread.Run(null, () => lazy.GetValueAsync());
                Task first = await Task.WhenAny(call, Task.Delay(TimeSpan.FromSeconds(2), TestContext.Current.CancellationToken));

                Assert.Same(call, first);
                release.Set();
                Assert.Equal(1, await (await call).WithTimeout());
            }
            finally
            {
                release.Set();
            }
        }

        [Fact]
        public async Task A_first_caller_blocking_its_single_threaded_context_does_not_deadlock()
        {
            // The same scenario deadlocks with Lazy<Task<T>> (see BaselineTests).
            var context = new QueueingSynchronizationContext();
            var lazy = new AsyncLazy<int>(async () =>
            {
                await Task.Yield();
                return 1;
            });

            bool completed = await DedicatedThread.Run(context, () => lazy.GetValueAsync().Wait(TimeSpan.FromSeconds(3))).WithTimeout();

            Assert.True(completed);
        }

        [Fact]
        public async Task Execution_context_flows_into_the_factory()
        {
            var local = new AsyncLocal<string?> { Value = "first-caller" };
            var lazy = new AsyncLazy<string?>(() => Task.FromResult<string?>(local.Value));

            Assert.Equal("first-caller", await lazy.GetValueAsync().WithTimeout());
        }

        [Fact]
        public async Task The_factory_does_not_run_on_the_callers_TaskScheduler()
        {
            var observed = Gate.Create<TaskScheduler>();
            var lazy = new AsyncLazy<int>(() =>
            {
                observed.TrySetResult(TaskScheduler.Current);
                return Task.FromResult(1);
            });
            TaskScheduler custom = new ConcurrentExclusiveSchedulerPair().ExclusiveScheduler;

            await Task.Factory.StartNew(() => lazy.GetValueAsync(), CancellationToken.None, TaskCreationOptions.None, custom)
                .Unwrap().WithTimeout();

            Assert.Same(TaskScheduler.Default, await observed.Task.WithTimeout());
        }

        [Fact]
        public async Task The_value_constructor_returns_an_already_completed_task()
        {
            var lazy = new AsyncLazy<int>(5);

            Task<int> value = lazy.GetValueAsync();

            Assert.True(value.IsCompletedSuccessfully);
            Assert.Equal(5, await value);
        }
    }
}
