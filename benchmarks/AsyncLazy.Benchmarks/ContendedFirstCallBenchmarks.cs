using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using NitoEx = Nito.AsyncEx;
using Vs = Microsoft.VisualStudio.Threading;

namespace AsyncLazyBenchmarks
{
    /// <summary>
    /// Several threads making the first call on a new instance at about the same time.
    /// </summary>
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    public class ContendedFirstCallBenchmarks
    {
        private Task<int>[] _tasks = null!;

        [ParamsSource(nameof(ThreadCounts))]
        public int Threads { get; set; }

        public static IEnumerable<int> ThreadCounts => new[] { 2, Environment.ProcessorCount }.Distinct();

        [GlobalSetup]
        public void Setup() => _tasks = new Task<int>[Threads];

        [Benchmark(Baseline = true)]
        public Task LazyOfTask()
        {
            var lazy = new Lazy<Task<int>>(Values<int>.Completed);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = Task.Run(() => lazy.Value);
            }

            return Task.WhenAll(_tasks);
        }

        [Benchmark]
        public Task AsyncLazy()
        {
            var lazy = new AsyncLazy<int>(Values<int>.Completed);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = Task.Run(() => lazy.GetValueAsync());
            }

            return Task.WhenAll(_tasks);
        }

        [Benchmark]
        public Task Nito()
        {
            var lazy = new NitoEx.AsyncLazy<int>(Values<int>.Completed);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = Task.Run(() => lazy.Task);
            }

            return Task.WhenAll(_tasks);
        }

        [Benchmark]
        public Task VsThreading()
        {
            var lazy = new Vs.AsyncLazy<int>(Values<int>.Completed);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = Task.Run(() => lazy.GetValueAsync());
            }

            return Task.WhenAll(_tasks);
        }
    }
}
