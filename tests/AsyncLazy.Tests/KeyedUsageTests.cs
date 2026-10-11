using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>Keyed usage works by composing with ConcurrentDictionary</summary>
    public sealed class KeyedUsageTests
    {
        [Fact]
        public async Task A_GetOrAdd_race_runs_each_keys_factory_once_stress()
        {
            const int Iterations = 20, Callers = 64, Keys = 4;
            for (int iteration = 0; iteration < Iterations; iteration++)
            {
                var cache = new ConcurrentDictionary<int, AsyncLazy<int>>();
                int[] calls = new int[Keys];
                using var start = new ManualResetEventSlim();

                Task<int>[] callers = Enumerable.Range(0, Callers)
                    .Select(i => Task.Factory.StartNew(() =>
                    {
                        start.Wait();
                        return cache.GetOrAdd(i % Keys, key => new AsyncLazy<int>(async () =>
                        {
                            Interlocked.Increment(ref calls[key]);
                            await Task.Yield();
                            return key * 10;
                        })).GetValueAsync();
                    }, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default).Unwrap())
                    .ToArray();
                start.Set();
                int[] values = await Task.WhenAll(callers).WithTimeout();

                Assert.All(calls, c => Assert.Equal(1, c));
                for (int i = 0; i < Callers; i++)
                    Assert.Equal(i % Keys * 10, values[i]);
            }
        }

        [Fact]
        public async Task A_failure_for_one_key_is_retried_without_eviction_code()
        {
            var cache = new ConcurrentDictionary<string, AsyncLazy<int>>();
            var calls = new ConcurrentDictionary<string, int>();

            // Note what is absent: no IsFaulted check, no TryRemove, no identity-checked eviction.
            Task<int> Get(string key) => cache.GetOrAdd(key, k => new AsyncLazy<int>(() =>
                calls.AddOrUpdate(k, 1, (_, n) => n + 1) == 1 && k == "flaky"
                    ? Task.FromException<int>(new TestException())
                    : Task.FromResult(k.Length))).GetValueAsync();

            await Assert.ThrowsAsync<TestException>(() => Get("flaky").WithTimeout());
            Assert.Equal(5, await Get("flaky").WithTimeout());
            Assert.Equal(6, await Get("stable").WithTimeout());

            Assert.Equal(2, calls["flaky"]);
            Assert.Equal(1, calls["stable"]);
        }
    }
}
