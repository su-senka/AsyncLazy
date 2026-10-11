using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests.Infrastructure
{
    /// <summary>
    /// A single-threaded context like a UI thread: work posted to it is queued and only runs if its
    /// thread pumps the queue. Tests block that thread on purpose to reproduce sync-over-async deadlocks.
    /// </summary>
    internal sealed class QueueingSynchronizationContext : SynchronizationContext
    {
        private readonly BlockingCollection<(SendOrPostCallback Callback, object? State)> _queue = [];

        public int PendingPosts => _queue.Count;

        public override void Post(SendOrPostCallback d, object? state) => _queue.Add((d, state));

        public override void Send(SendOrPostCallback d, object? state) => throw new NotSupportedException();

        public override SynchronizationContext CreateCopy() => this;
    }

    internal static class DedicatedThread
    {
        /// <summary>Runs <paramref name="body"/> on a new background thread with <paramref name="context"/> installed.</summary>
        public static Task<TResult> Run<TResult>(SynchronizationContext? context, Func<TResult> body)
        {
            TaskCompletionSource<TResult> result = Gate.Create<TResult>();
            var thread = new Thread(() =>
                {
                    SynchronizationContext.SetSynchronizationContext(context);
                    try { result.SetResult(body()); }
                    catch (Exception e) { result.SetException(e); }
                })
                { IsBackground = true };
            thread.Start();
            return result.Task;
        }
    }
}
