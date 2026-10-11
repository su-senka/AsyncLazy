using System;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using NitoEx = Nito.AsyncEx;
using Vs = Microsoft.VisualStudio.Threading;

namespace AsyncLazyBenchmarks
{
    /// <summary>
    /// Getting the value after it exists, which is nearly every call in a program's life.
    /// </summary>
    [MemoryDiagnoser]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(string))]
    public class HotPathBenchmarks<T>
    {
        private readonly CancellationTokenSource _cts = new();
        private Lazy<Task<T>> _lazyOfTask = null!;
        private AsyncLazy<T> _asyncLazy = null!;
        private NitoEx.AsyncLazy<T> _nito = null!;
        private Vs.AsyncLazy<T> _vs = null!;

        [GlobalSetup]
        public void Setup()
        {
            // Every instance produces its value through its factory
            _lazyOfTask = new Lazy<Task<T>>(Values<T>.Completed);
            _asyncLazy = new AsyncLazy<T>(Values<T>.Completed);
            _nito = new NitoEx.AsyncLazy<T>(Values<T>.Completed);
            _vs = new Vs.AsyncLazy<T>(Values<T>.Completed);

            Task.WaitAll(_lazyOfTask.Value, _asyncLazy.GetValueAsync(), _nito.Task, _vs.GetValueAsync());

            // The attempt's outcome is processed just after its task completes
            while (!_asyncLazy.IsValueCreated) Thread.Yield();
        }

        [GlobalCleanup]
        public void Cleanup() => _cts.Dispose();

        [Benchmark(Baseline = true), BenchmarkCategory("NoToken")]
        public object LazyOfTask() => _lazyOfTask.Value;

        [Benchmark, BenchmarkCategory("NoToken")]
        public object AsyncLazy() => _asyncLazy.GetValueAsync();

        [Benchmark, BenchmarkCategory("NoToken")]
        public object Nito() => _nito.Task;

        [Benchmark, BenchmarkCategory("NoToken")]
        public object VsThreading() => _vs.GetValueAsync();

        [Benchmark(Baseline = true), BenchmarkCategory("Token")]
        public object LazyOfTask_Token() => _lazyOfTask.Value.WaitAsync(_cts.Token);

        [Benchmark, BenchmarkCategory("Token")]
        public object AsyncLazy_Token() => _asyncLazy.GetValueAsync(_cts.Token);

        [Benchmark, BenchmarkCategory("Token")]
        public object Nito_Token() => _nito.Task.WaitAsync(_cts.Token);

        [Benchmark, BenchmarkCategory("Token")]
        public object VsThreading_Token() => _vs.GetValueAsync(_cts.Token);
    }
}
