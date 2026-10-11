using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>
    /// The same scenarios against the widely copied <c>Lazy&lt;Task&lt;T&gt;&gt;</c> pattern.
    /// </summary>
    public sealed class BaselineTests
    {
        [Fact]
        public async Task Lazy_of_Task_keeps_a_transient_failure_forever()
        {
            int calls = 0;
            var lazy = new Lazy<Task<int>>(async () =>
            {
                await Task.Yield();
                return Interlocked.Increment(ref calls) == 1 ? throw new TestException("transient") : 1;
            });

            await Assert.ThrowsAsync<TestException>(() => lazy.Value.WithTimeout());

            // The dependency has recovered, but every later caller still gets the old failure.
            await Assert.ThrowsAsync<TestException>(() => lazy.Value.WithTimeout());
            Assert.Equal(1, calls);
        }

        [Fact]
        public async Task Lazy_of_Task_deadlocks_when_the_first_caller_blocks_its_single_threaded_context()
        {
            // The factory runs inline on the first caller's thread and its continuation
            // is posted back to that thread's context, which is blocked waiting for the result.
            var context = new QueueingSynchronizationContext();
            var lazy = new Lazy<Task<int>>(async () =>
            {
                await Task.Yield();
                return 1;
            });

            bool completed = await DedicatedThread.Run(context, () => lazy.Value.Wait(TimeSpan.FromSeconds(1))).WithTimeout();

            Assert.False(completed);
            Assert.True(context.PendingPosts > 0, "The factory's continuation is stuck in the blocked context's queue.");
        }

        [Fact]
        public async Task Lazy_of_Task_lets_the_first_callers_token_cancel_the_shared_result_permanently()
        {
            // The shared factory closes over whichever caller arrived first.
            using var firstCaller = new CancellationTokenSource();
            var lazy = new Lazy<Task<int>>(() => SlowAsync(firstCaller.Token));
            Task<int> first = lazy.Value;

            firstCaller.Cancel();
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => first.WithTimeout());

            // A different caller that never canceled anything still gets the canceled result.
            await Assert.ThrowsAnyAsync<OperationCanceledException>(() => lazy.Value.WithTimeout());

            static async Task<int> SlowAsync(CancellationToken token)
            {
                await Task.Delay(Timeout.Infinite, token);
                return 1;
            }
        }

        [Fact]
        public async Task Lazy_of_Task_in_a_dictionary_needs_hand_written_eviction_to_recover()
        {
            var cache = new ConcurrentDictionary<string, Lazy<Task<int>>>();
            int calls = 0;

            Task<int> Get(string key) => cache.GetOrAdd(key, _ => new Lazy<Task<int>>(() =>
                Interlocked.Increment(ref calls) == 1
                    ? Task.FromException<int>(new TestException())
                    : Task.FromResult(1))).Value;

            await Assert.ThrowsAsync<TestException>(() => Get("key").WithTimeout());

            // Without IsFaulted checks and identity-checked TryRemove, the failure is permanent for this key.
            await Assert.ThrowsAsync<TestException>(() => Get("key").WithTimeout());
            Assert.Equal(1, calls);
        }
    }
}
