extern alias NoRecursionDetection;
using System;
using System.Threading;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using NitoEx = Nito.AsyncEx;
using Vs = Microsoft.VisualStudio.Threading;

namespace AsyncLazyBenchmarks
{
    /// <summary>
    /// Callers joining an attempt that is still running.
    /// </summary>
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    public class JoinInFlightBenchmarks
    {
        private readonly CancellationTokenSource _cts = new();
        private Task<int>[] _tasks = null!;
        private CancellationToken _token;

        [Params(1, 8, 64)]
        public int Waiters { get; set; }

        [Params(false, true)]
        public bool WithToken { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            _tasks = new Task<int>[Waiters];
            _token = WithToken ? _cts.Token : CancellationToken.None;
        }

        [GlobalCleanup]
        public void Cleanup() => _cts.Dispose();

        [Benchmark(Baseline = true)]
        public Task LazyOfTask()
        {
            var gate = NewGate();
            var lazy = new Lazy<Task<int>>(() => gate.Task);
            for (int i = 0; i < _tasks.Length; i++)
            {
                // WaitAsync without a cancelable token returns the same task
                _tasks[i] = lazy.Value.WaitAsync(_token);
            }

            return Release(gate);
        }

        [Benchmark]
        public Task AsyncLazy()
        {
            var gate = NewGate();
            var lazy = new AsyncLazy<int>(() => gate.Task);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = lazy.GetValueAsync(_token);
            }

            return Release(gate);
        }

        [Benchmark]
        public Task AsyncLazy_NoRecursionDetection()
        {
            var gate = NewGate();
            var lazy = new NoRecursionDetection::System.Threading.Tasks.AsyncLazy<int>(() => gate.Task);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = lazy.GetValueAsync(_token);
            }

            return Release(gate);
        }

        [Benchmark]
        public Task Nito()
        {
            var gate = NewGate();
            var lazy = new NitoEx.AsyncLazy<int>(() => gate.Task);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = lazy.Task.WaitAsync(_token);
            }

            return Release(gate);
        }

        [Benchmark]
        public Task VsThreading()
        {
            var gate = NewGate();
            var lazy = new Vs.AsyncLazy<int>(() => gate.Task);
            for (int i = 0; i < _tasks.Length; i++)
            {
                _tasks[i] = lazy.GetValueAsync(_token);
            }

            return Release(gate);
        }

        private static TaskCompletionSource<int> NewGate() => new(TaskCreationOptions.RunContinuationsAsynchronously);

        private Task Release(TaskCompletionSource<int> gate)
        {
            gate.SetResult(Values<int>.Instance);
            return Task.WhenAll(_tasks);
        }
    }
}
