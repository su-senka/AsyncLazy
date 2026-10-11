using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncLazyTests.Infrastructure
{
    /// <summary>
    /// Helpers for the tests whose names end in _gc. Each one first proves that the runtime actually collects what it
    /// should, and skips the test otherwise, so an unreliable GC can't produce a false pass or failure.
    /// </summary>
    internal static class Gc
    {
        public static void Collect()
        {
            for (int i = 0; i < 3; i++)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static void SkipUnlessCollectionIsReliable()
        {
            WeakReference probe = CreateUnreferencedObject();
            Collect();
            Assert.SkipWhen(probe.IsAlive, "Forced garbage collection is not reliable on this runtime.");
        }

        /// <summary>
        /// Runs <paramref name="scenario"/>, forces collection, and returns every unobserved task exception
        /// whose message contains <paramref name="marker"/>. Skips the test if a known-unobserved fault isn't reported.
        /// </summary>
        public static async Task<IReadOnlyCollection<Exception>> CaptureUnobservedAsync(string marker, Func<Task> scenario)
        {
            var seen = new ConcurrentQueue<Exception>();
            string probeMarker = $"probe-{Guid.NewGuid()}";

            void Handler(object? sender, UnobservedTaskExceptionEventArgs e)
            {
                foreach (Exception inner in e.Exception.Flatten().InnerExceptions)
                    if (inner.Message.Contains(marker) || inner.Message.Contains(probeMarker))
                        seen.Enqueue(inner);
                e.SetObserved();
            }

            TaskScheduler.UnobservedTaskException += Handler;
            try
            {
                FaultAndForget(probeMarker);
                await scenario();
                Collect();
                await Task.Delay(100, TestContext.Current.CancellationToken);
                Collect();
            }
            finally
            {
                TaskScheduler.UnobservedTaskException -= Handler;
            }

            Assert.SkipUnless(seen.Any(e => e.Message.Contains(probeMarker)),
                "Unobserved task exceptions are not reported reliably on this runtime.");
            return seen.Where(e => e.Message.Contains(marker)).ToArray();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static WeakReference CreateUnreferencedObject() => new(new object());

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void FaultAndForget(string marker) => _ = Task.FromException(new TestException(marker));
    }
}
