using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests.Infrastructure
{
    /// <summary>
    /// A factory whose every invocation ("attempt") is completed explicitly by the test,
    /// so interleavings are forced rather than left to timing.
    /// </summary>
    internal sealed class ControlledFactory<T>
    {
        private readonly Lock _lock = new();
        private readonly List<TaskCompletionSource<T>> _attempts = [];
        private readonly List<TaskCompletionSource<CancellationToken>> _started = [];

        /// <summary>Number of times the factory has been invoked.</summary>
        public int Calls
        {
            get { lock (_lock) return _attempts.Count; }
        }

        public Task<T> Invoke() => Invoke(CancellationToken.None);

        /// <summary>The attempt is canceled when the token is.</summary>
        public Task<T> Invoke(CancellationToken cancellationToken)
        {
            TaskCompletionSource<T> attempt = Gate.Create<T>();
            lock (_lock)
            {
                _attempts.Add(attempt);
                StartedSource(_attempts.Count - 1).TrySetResult(cancellationToken);
            }
            cancellationToken.Register(() => attempt.TrySetCanceled(cancellationToken));
            return attempt.Task;
        }

        /// <summary>Completes when attempt <paramref name="index"/> (zero-based) has started, with the token it received.</summary>
        public Task<CancellationToken> StartedAsync(int index)
        {
            lock (_lock) return StartedSource(index).Task.WithTimeout();
        }

        /// <summary>The completion source controlling attempt <paramref name="index"/>.</summary>
        public TaskCompletionSource<T> Attempt(int index)
        {
            lock (_lock) return _attempts[index];
        }

        private TaskCompletionSource<CancellationToken> StartedSource(int index)
        {
            while (_started.Count <= index) _started.Add(Gate.Create<CancellationToken>());
            return _started[index];
        }
    }

    internal static class Gate
    {
        public static TaskCompletionSource<T> Create<T>() => new(TaskCreationOptions.RunContinuationsAsynchronously);

        public static TaskCompletionSource Create() => new(TaskCreationOptions.RunContinuationsAsynchronously);
    }

    internal sealed class TestException(string message = "test failure") : Exception(message);
}
