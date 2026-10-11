# Benchmarks

What the benchmarks measure, how to run them, and how to read the results.

## Scenarios

| Class | Scenario | Question | Passing |
|---|---|---|---|
| `HotPathBenchmarks<T>` | Getting the value after it exists, without and with a cancelable token | Does the type cost anything on nearly every call? | **0 B**; within about 1 ns of `Lazy<Task<T>>.Value` |
| `FirstCallBenchmarks<T>` | Construction to value, with a factory that completes synchronously and one that yields | What do the thread-pool hop and recursion detection cost? | Within about 2× of `LazyOfTask_TaskRun` |
| `JoinInFlightBenchmarks` | 1, 8 or 64 callers join a running attempt | What does each waiter cost? | No more per waiter than `LazyOfTask` |
| `ContendedFirstCallBenchmarks` | 2 threads, and one per core, race on a new instance | Does a race on the first call cost anything unexpected? | Directional only |

### Rows

| Row | What | Runs the factory | Caches failures |
|---|---|---|---|
| `LazyOfTask` | `new Lazy<Task<T>>(factory)`, the copied pattern; the baseline | Inline on the first caller | Yes |
| `LazyOfTask_TaskRun` | `new Lazy<Task<T>>(() => Task.Run(factory))`, offloaded by hand | Thread pool | Yes |
| `AsyncLazy` | This prototype | Thread pool | No |
| `AsyncLazy_NoHop` | This prototype's source without the thread-pool hop | Inline on the first caller | No |
| `AsyncLazy_NoRecursionDetection` | This prototype's source without recursion detection | Thread pool | No |
| `Nito` | Nito.AsyncEx.Coordination 5.1.2, default flags | Thread pool | Yes |
| `Nito_ExecuteOnCallingThread` | Same, with `AsyncLazyFlags.ExecuteOnCallingThread` | Inline on the first caller | Yes |
| `VsThreading` | Microsoft.VisualStudio.Threading 18.7.23, no `JoinableTaskFactory` | Inline on the first caller | Yes |

Faster rows are often the ones with the problems that the baseline tests reproduce.

### Reading

- `LazyOfTask` and `LazyOfTask_TaskRun` bracket the cost of the thread-pool hop: inline, and the hand-written equivalent of what this prototype does.
- `AsyncLazy` minus `AsyncLazy_NoHop` is the cost of the hop. `AsyncLazy` minus `AsyncLazy_NoRecursionDetection` is the cost of recursion detection.
- The harness waits for each returned task. A task that is still running is waited for by blocking, so the rows that offload include a round trip to the thread pool and back.

## Running

From the repository root:

```bash
dotnet run -c Release --project benchmarks/AsyncLazy.Benchmarks -- --filter '*'
```

The full run takes roughly 30 to 60 minutes. To run one class, use `--filter '*HotPath*'`.

**To see the hot path's machine code** (Windows and Linux only; BenchmarkDotNet's disassembler doesn't support macOS):

```bash
dotnet run -c Release --project benchmarks/AsyncLazy.Benchmarks -- --filter '*HotPath*' --disasm
```

## Running on Azure

The proposal's numbers come from Azure VMs: every environment in one place, with the same SDK and the same method, reproducible by anyone with the script.

| Environment | VM size | Image |
|---|---|---|
| `linux-x64` | `Standard_D8s_v5` (Intel Xeon) | Ubuntu 24.04 |
| `windows-x64` | `Standard_D8s_v5` (Intel Xeon) | Windows Server 2025 Datacenter |
| `linux-arm64` | `Standard_D8ps_v5` (Ampere Altra, a whole core per vCPU) | Ubuntu 24.04 |
| `linux-x64-amd` | `Standard_D8as_v5` (AMD EPYC) | Ubuntu 24.04 |

```bash
benchmarks/azure/run.sh --dry linux-x64      # checks the pipeline end to end, about 20 minutes
benchmarks/azure/run.sh all                  # the real runs, one after another, about 1.5 hours each
benchmarks/azure/run.sh cleanup              # deletes anything a crashed or interrupted run left behind
```

**On each VM:** first-boot activity is given time to settle; package updates, Windows Update and Defender's real-time scanning are turned off; the .NET SDK version is the same on every VM. Then:

1. Run 1: every benchmark.
2. Run 2: the hot path and first call again, to show whether the VM was noisy (compare with run 1). This run also records the disassembly of the hot path.

Each result folder holds `environment.txt` (commit, VM size, CPU, OS, SDK), `run1/`, `run2/` and the VM's log.

**Reading VM results:** allocations and disassembly are exact on any machine. Timings are reliable as ratios between rows of the same run. Absolute timings below about 1 ns are below what can be measured on any machine; compare them with `Lazy<Task<T>>.Value` instead. If run 1 and run 2 disagree by more than about 10% on a row measured in microseconds, rerun that environment. Rows below about 2 ns can differ more between runs, because code placement changes between processes; report them as a range over both runs.

**Testing the script:** `benchmarks/azure/test/test-local.sh` runs the whole pipeline on this machine without Azure, using a fake `az` and a local stand-in for the storage container.
