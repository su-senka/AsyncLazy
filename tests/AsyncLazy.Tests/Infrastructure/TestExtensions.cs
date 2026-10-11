using System;
using System.Threading.Tasks;

namespace AsyncLazyTests.Infrastructure
{
    internal static class TestExtensions
    {
        /// <summary>Upper bound for anything a test waits on, so a broken implementation fails instead of hanging.</summary>
        public static readonly TimeSpan Timeout = TimeSpan.FromSeconds(10);

        public static Task<T> WithTimeout<T>(this Task<T> task) =>
            task.WaitAsync(Timeout, TestContext.Current.CancellationToken);

        public static Task WithTimeout(this Task task) =>
            task.WaitAsync(Timeout, TestContext.Current.CancellationToken);

        /// <summary>
        /// A short pause used only to show that something does NOT happen (e.g. a factory is not invoked).
        /// Never used to wait for something that should happen.
        /// </summary>
        public static Task Settle() => Task.Delay(100, TestContext.Current.CancellationToken);
    }
}
