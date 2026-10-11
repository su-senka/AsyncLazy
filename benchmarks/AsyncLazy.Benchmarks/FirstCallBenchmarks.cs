extern alias NoHop;
extern alias NoRecursionDetection;
using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using NitoEx = Nito.AsyncEx;
using Vs = Microsoft.VisualStudio.Threading;

namespace AsyncLazyBenchmarks
{
    /// <summary>
    /// The first call on a new instance, from construction until the value is available.
    /// </summary>
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class FirstCallBenchmarks<T>
    {
        private Func<Task<T>> _factory = null!;
        private Func<Task<T>> _offloadedFactory = null!;

        [Params(FactoryKind.Completed, FactoryKind.Yielding)]
        public FactoryKind Factory { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            Func<Task<T>> factory = Values<T>.Factory(Factory);
            _factory = factory;
            _offloadedFactory = () => Task.Run(factory);
        }

        [Benchmark(Baseline = true)]
        public Task<T> LazyOfTask() => new Lazy<Task<T>>(_factory).Value;

        [Benchmark]
        public Task<T> LazyOfTask_TaskRun() => new Lazy<Task<T>>(_offloadedFactory).Value;

        [Benchmark]
        public Task<T> AsyncLazy() => new AsyncLazy<T>(_factory).GetValueAsync();

        [Benchmark]
        public Task<T> AsyncLazy_NoHop() => new NoHop::System.Threading.Tasks.AsyncLazy<T>(_factory).GetValueAsync();

        [Benchmark]
        public Task<T> AsyncLazy_NoRecursionDetection() =>
            new NoRecursionDetection::System.Threading.Tasks.AsyncLazy<T>(_factory).GetValueAsync();

        [Benchmark]
        public Task<T> Nito() => new NitoEx.AsyncLazy<T>(_factory).Task;

        [Benchmark]
        public Task<T> Nito_ExecuteOnCallingThread() =>
            new NitoEx.AsyncLazy<T>(_factory, NitoEx.AsyncLazyFlags.ExecuteOnCallingThread).Task;

        [Benchmark]
        public Task<T> VsThreading() => new Vs.AsyncLazy<T>(_factory).GetValueAsync();
    }
}
