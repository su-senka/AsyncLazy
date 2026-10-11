using System;
using System.Threading.Tasks;

namespace AsyncLazyBenchmarks
{
    public enum FactoryKind
    {
        /// <summary>Returns an already-completed task.</summary>
        Completed,

        /// <summary>Yields once before completing, like any factory that does real I/O.</summary>
        Yielding,
    }

    /// <summary>The value every benchmark produces, and factories that produce it.</summary>
    internal static class Values<T>
    {
        // 1000 is outside Task.FromResult's small-integer cache, so a completed task really allocates
        public static readonly T Instance = typeof(T) == typeof(int) ? (T)(object)1000 : (T)(object)"value";

        public static readonly Func<Task<T>> Completed = static () => Task.FromResult(Instance);

        public static readonly Func<Task<T>> Yielding = static async () =>
        {
            await Task.Yield();
            return Instance;
        };

        public static Func<Task<T>> Factory(FactoryKind kind) => kind == FactoryKind.Completed ? Completed : Yielding;
    }
}
