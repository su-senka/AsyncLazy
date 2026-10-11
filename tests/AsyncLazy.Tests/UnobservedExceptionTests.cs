using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncLazyTests
{
    /// <summary>Unobserved exceptions: abandoned attempts must not produce noise</summary>
    public sealed class UnobservedExceptionTests
    {
        [Fact]
        public async Task An_attempt_that_faults_after_every_waiter_canceled_is_not_reported_as_unobserved()
        {
            string marker = $"abandoned-{Guid.NewGuid()}";
            AsyncLazy<int>? keepAlive = null;

            IReadOnlyCollection<Exception> unobserved = await Gc.CaptureUnobservedAsync(marker, async () =>
                keepAlive = await AbandonThenFault(marker));

            Assert.Empty(unobserved);
            GC.KeepAlive(keepAlive);
        }

        [Fact]
        public async Task A_fire_and_forget_warm_up_that_faults_is_not_reported_as_unobserved()
        {
            string marker = $"warm-up-{Guid.NewGuid()}";
            AsyncLazy<int>? keepAlive = null;

            IReadOnlyCollection<Exception> unobserved = await Gc.CaptureUnobservedAsync(marker, async () =>
                keepAlive = await WarmUpThenFault(marker));

            Assert.Empty(unobserved);
            GC.KeepAlive(keepAlive);
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static async Task<AsyncLazy<int>> AbandonThenFault(string marker)
        {
            TaskCompletionSource started = Gate.Create(), release = Gate.Create(), faulting = Gate.Create();
            var lazy = new AsyncLazy<int>(async () =>
            {
                started.SetResult();
                await release.Task;
                faulting.SetResult();
                throw new TestException(marker);
            });

            using (var caller = new CancellationTokenSource())
            {
                Task<int> wait = lazy.GetValueAsync(caller.Token);
                await started.Task.WithTimeout();
                caller.Cancel();
                await Assert.ThrowsAnyAsync<OperationCanceledException>(() => wait.WithTimeout());
            }

            release.SetResult();
            await faulting.Task.WithTimeout();
            await TestExtensions.Settle();
            return lazy;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static async Task<AsyncLazy<int>> WarmUpThenFault(string marker)
        {
            TaskCompletionSource faulting = Gate.Create();
            var lazy = new AsyncLazy<int>(async () =>
            {
                await Task.Yield();
                faulting.SetResult();
                throw new TestException(marker);
            });

            _ = lazy.GetValueAsync();

            await faulting.Task.WithTimeout();
            await TestExtensions.Settle();
            return lazy;
        }
    }
}
