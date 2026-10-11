using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

// The ASYNCLAZY_ABLATE_* symbols are defined only by the ablation builds in benchmarks/, each of which
// removes one design decision to measure its cost.

namespace System.Threading.Tasks
{
    /// <summary>
    /// Provides asynchronous lazy initialization: the value is produced on first demand,
    /// shared by all concurrent callers, and kept once it has been produced successfully.
    /// </summary>
    /// <typeparam name="T">The type of the lazily initialized value.</typeparam>
    /// <remarks>
    /// <para>At most one attempt to produce the value runs at a time. Only a successful attempt is kept:
    /// if an attempt faults or is canceled, every caller waiting on it observes that outcome, and the
    /// next call starts a new attempt.</para>
    /// <para>The factory always runs on the thread pool, so it never captures a caller's
    /// <see cref="SynchronizationContext"/> or <see cref="TaskScheduler"/>. The caller's
    /// <see cref="ExecutionContext"/> flows into it.</para>
    /// <para>If code running as part of an attempt calls <see cref="GetValueAsync"/> on an instance whose
    /// attempt it is part of, directly or through a cycle of instances, the returned task faults with
    /// <see cref="InvalidOperationException"/> instead of waiting forever.</para>
    /// <para>Detection follows the <see cref="ExecutionContext"/>, not the chain of awaits. Work the factory starts
    /// without awaiting is therefore part of the attempt too, and fails the same way if it requests the value
    /// before the attempt completes. Start such work inside <see cref="ExecutionContext.SuppressFlow"/> to have it
    /// wait normally. Detection is best effort: a cycle whose instances were started by different callers, or a
    /// dependency through work that doesn't carry the execution context, still waits forever.</para>
    /// </remarks>
    [DebuggerDisplay("IsValueCreated = {IsValueCreated}")]
    public sealed class AsyncLazy<T>
    {
        // The single source of truth: null, attempt, or Task<T>. Every transition is atomic.
        private object? _state;

        // The same completed task as _state holds once the value exists; null until then. Written once.
        private Task<T>? _value;

        // Func<Task<T>> or Func<CancellationToken, Task<T>>. Released once the value exists.
        private Delegate? _factory;

        // Passed to the factory; owned by whoever created this instance. Released once the value exists.
        private CancellationToken _cancellationToken;

        /// <summary>Initializes a new instance that produces its value with <paramref name="factory"/>.</summary>
        /// <param name="factory">The delegate that produces the value. It is not invoked until the value is first requested.</param>
        /// <exception cref="ArgumentNullException"><paramref name="factory"/> is <see langword="null"/>.</exception>
        public AsyncLazy(Func<Task<T>> factory)
        {
            ArgumentNullException.ThrowIfNull(factory);

            _factory = factory;
        }

        /// <summary>
        /// Initializes a new instance that produces its value with <paramref name="factory"/>,
        /// passing it a token that is controlled by the owner of this instance.
        /// </summary>
        /// <param name="factory">The delegate that produces the value. It receives <paramref name="cancellationToken"/>.</param>
        /// <param name="cancellationToken">
        /// A token that stops the shared work, for example when the owner shuts down. Once it is canceled,
        /// no new attempts start. The factory is responsible for observing it. Callers' tokens never cancel the shared work.
        /// </param>
        /// <exception cref="ArgumentNullException"><paramref name="factory"/> is <see langword="null"/>.</exception>
        /// <remarks>
        /// <para>Cancellation is cooperative. Callers waiting on an attempt wait until the factory completes, even after
        /// <paramref name="cancellationToken"/> is canceled. To stop waiting when the owner shuts down, wait with that token
        /// too, for example <c>GetValueAsync(cancellationToken).WaitAsync(lifetimeToken)</c>; once the value exists, this
        /// returns the same completed task and allocates nothing.</para>
        /// <para>After <paramref name="cancellationToken"/> is canceled, <see cref="GetValueAsync"/> never starts an attempt:
        /// it returns the value if it exists, the outcome of an attempt that is still running, or a canceled task. An owner
        /// can use it to obtain, and dispose of, a value that an attempt produces after shutdown.</para>
        /// </remarks>
        public AsyncLazy(Func<CancellationToken, Task<T>> factory, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(factory);

            _factory = factory;
            _cancellationToken = cancellationToken;
        }

        /// <summary>Initializes a new instance whose value is already created.</summary>
        /// <param name="value">The preinitialized value.</param>
        public AsyncLazy(T value)
        {
            _value = Task.FromResult(value);
            _state = _value;
        }

        /// <summary>Gets whether the value has been produced successfully.</summary>
        public bool IsValueCreated => Volatile.Read(ref _value) is not null;

        /// <summary>Gets the value, starting an attempt to produce it if none is running.</summary>
        /// <param name="cancellationToken">Cancels only this caller's wait. It never cancels the shared attempt.</param>
        /// <returns>
        /// A task that completes with the value, or with the outcome of the attempt this caller waited on. It faults with
        /// <see cref="InvalidOperationException"/> if the call was made from inside the attempt it would wait on,
        /// directly or through a cycle of instances.
        /// </returns>
        public Task<T> GetValueAsync(CancellationToken cancellationToken = default)
        {
            // The token is checked first, even when the value exists.
            if (cancellationToken.IsCancellationRequested)
            {
                return Task.FromCanceled<T>(cancellationToken);
            }

            // Once the value exists, every call returns the same completed task.
            if (Volatile.Read(ref _value) is { } value)
            {
                return value;
            }

            return GetOrStartAttemptAsync(cancellationToken);
        }

        /// <summary>Gets the value if it has already been produced, without waiting and without starting an attempt.</summary>
        /// <param name="value">The value, if it has been produced.</param>
        /// <returns><see langword="true"/> if the value has been produced; otherwise, <see langword="false"/>.</returns>
        public bool TryGetValue([MaybeNullWhen(false)] out T value)
        {
            if (Volatile.Read(ref _value) is { } task)
            {
                value = task.Result;
                return true;
            }

            value = default;
            return false;
        }

        private Task<T> GetOrStartAttemptAsync(CancellationToken cancellationToken)
        {
            while (true)
            {
                object? state = Volatile.Read(ref _state);

                if (state is Task<T> value)
                {
                    return value;
                }

                if (state is Attempt running)
                {
#if !ASYNCLAZY_ABLATE_RECURSION_DETECTION
                    if (AsyncLazyAttemptFrame.IsInside(running))
                    {
                        // Waiting would never finish: this flow is part of the attempt it would wait on. Reported
                        // through the task, not thrown: the flow may be work the factory started without awaiting,
                        // where a synchronous throw from a callback (a timer, an event) could end the process.
                        return Task.FromException<T>(new InvalidOperationException(SR.AsyncLazy_RecursiveAccess));
                    }
#endif

                    return running.WaitAsync(cancellationToken);
                }

                // No value and nothing running. Once the owner's token is canceled, no new attempts start.
                if (_cancellationToken.IsCancellationRequested)
                {
                    return Task.FromCanceled<T>(_cancellationToken);
                }

                var attempt = new Attempt(this);
                if (Interlocked.CompareExchange(ref _state, attempt, null) is null)
                {
#if ASYNCLAZY_ABLATE_HOP
                    _ = attempt.RunAsync();
#else
                    // Run on the thread pool so the factory never captures the caller's SynchronizationContext
                    // or TaskScheduler, and never blocks the caller.
                    ThreadPool.QueueUserWorkItem(static attempt => _ = attempt.RunAsync(), attempt, preferLocal: false);
#endif
                    return attempt.WaitAsync(cancellationToken);
                }

                // Another caller changed the state first, look again.
            }
        }

        /// <summary>One run of the factory, shared by every caller that waits while it runs.</summary>
        private sealed class Attempt
        {
            private readonly AsyncLazy<T> _owner;
            private readonly TaskCompletionSource<T> _completion = new(TaskCreationOptions.RunContinuationsAsynchronously);

            public Attempt(AsyncLazy<T> owner)
            {
                _owner = owner;
            }

            public Task<T> WaitAsync(CancellationToken cancellationToken) =>
                cancellationToken.CanBeCanceled ? _completion.Task.WaitAsync(cancellationToken) : _completion.Task;

            public async Task RunAsync()
            {
                // Mark this flow as part of the attempt. The mark flows into the factory and everything it
                // starts, which is how a factory waiting on its own attempt, or on a cycle, is detected.
#if !ASYNCLAZY_ABLATE_RECURSION_DETECTION
                AsyncLazyAttemptFrame frame = AsyncLazyAttemptFrame.Enter(this);
#endif

                Task<T> task = InvokeFactory();
                await ((Task)task).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);

#if !ASYNCLAZY_ABLATE_RECURSION_DETECTION
                // Anything long-lived the factory started (a timer, a connection, a background loop) keeps the
                // execution context it was started with, and so this frame. Detach the frame from the attempt
                // so it can't keep the attempt, this instance, or the value alive.
                frame.Exit();
#endif

                Complete(task);
            }

            private Task<T> InvokeFactory()
            {
                Delegate? factory = _owner._factory;
                Debug.Assert(factory is not null, "The factory is only released after success, when no attempt can start.");

                try
                {
                    Task<T>? task = factory is Func<Task<T>> simple
                        ? simple()
                        : ((Func<CancellationToken, Task<T>>)factory)(_owner._cancellationToken);

                    return task ?? Task.FromException<T>(new InvalidOperationException(SR.AsyncLazy_FactoryReturnedNull));
                }
                catch (Exception e)
                {
                    // A factory that throws before returning a task is treated exactly like a faulted task.
                    return Task.FromException<T>(e);
                }
            }

            private void Complete(Task<T> task)
            {
                Debug.Assert(task.IsCompleted);
                Debug.Assert(ReferenceEquals(Volatile.Read(ref _owner._state), this), "Only the running attempt changes the state.");

                // The state is always published before waiters are released, so a waiter that resumes and
                // calls again sees the value after a success, or starts a new attempt after a failure.
                if (task.IsCompletedSuccessfully)
                {
                    T value = task.Result;

                    // The value is final; don't keep the factory or the owner's token alive.
                    _owner._factory = null;
                    _owner._cancellationToken = default;

                    // _value first: once any call has returned the value, IsValueCreated and TryGetValue agree.
                    Task<T> completed = Task.FromResult(value);
                    Volatile.Write(ref _owner._value, completed);
                    Volatile.Write(ref _owner._state, completed);
                    _completion.SetResult(value);
                    return;
                }

                Volatile.Write(ref _owner._state, null);

                if (task.IsCanceled)
                {
                    _completion.SetCanceled(GetCancellationToken(task));
                    return;
                }

                _completion.SetException(task.Exception!.InnerExceptions);

                // Every waiter may have stopped waiting, or the call may have been fire-and-forget.
                // The failure is reported to whoever waits, but never as an unobserved task exception.
                _ = _completion.Task.Exception;
            }

            private static CancellationToken GetCancellationToken(Task<T> canceled)
            {
                try
                {
                    canceled.GetAwaiter().GetResult();
                }
                catch (OperationCanceledException e)
                {
                    return e.CancellationToken;
                }

                Debug.Fail("A canceled task always throws OperationCanceledException.");
                return default;
            }
        }
    }

    /// <summary>
    /// The chain of <see cref="AsyncLazy{T}"/> attempts the current asynchronous flow is running inside.
    /// Not generic, so a single chain covers cycles through instances with different value types.
    /// </summary>
    internal sealed class AsyncLazyAttemptFrame
    {
        private static readonly AsyncLocal<AsyncLazyAttemptFrame?> s_current = new();

        // Cleared when the attempt completes.
        private object? _attempt;
        private readonly AsyncLazyAttemptFrame? _parent;

        private AsyncLazyAttemptFrame(object attempt, AsyncLazyAttemptFrame? parent)
        {
            _attempt = attempt;
            _parent = parent;
        }

        /// <summary>Marks the current flow, and everything it starts, as part of <paramref name="attempt"/>.</summary>
        public static AsyncLazyAttemptFrame Enter(object attempt) => s_current.Value = new AsyncLazyAttemptFrame(attempt, s_current.Value);

        /// <summary>Ends the attempt for every flow that carries this frame, including flows that outlive it.</summary>
        public void Exit() => _attempt = null;

        /// <summary>Gets whether the current flow is part of <paramref name="attempt"/>.</summary>
        public static bool IsInside(object attempt)
        {
            for (AsyncLazyAttemptFrame? frame = s_current.Value; frame is not null; frame = frame._parent)
            {
                if (ReferenceEquals(frame._attempt, attempt))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
