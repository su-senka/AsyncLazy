# AsyncLazy&lt;T&gt; prototype

A prototype of a proposed `System.Threading.Tasks.AsyncLazy<T>` for the .NET base class library, built to accompany an API proposal in dotnet/runtime.

## For reviewers

To check the behavior yourself:

```bash
dotnet test   # 65 tests
```

- The four baseline tests (`BaselineTests.cs`) run the same scenarios against the widely copied `Lazy<Task<T>>` pattern. They pass *because* the problem is present, which makes the proposal's motivation reproducible.
- `benchmarks/README.md`: how to run the benchmarks, and the results.

## Layout

| Path | Contents |
|---|---|
| `src/AsyncLazy/AsyncLazy.cs` | The implementation |
| `src/AsyncLazy/SR.cs` | Stand-in for the runtime's generated resource strings |
| `tests/AsyncLazy.Tests/` | 65 tests on xUnit v3, one per required behavior (one runs twice) |
| `benchmarks/` | BenchmarkDotNet comparison with Nito.AsyncEx, VS threading and `Lazy<Task<T>>`, plus ablations of the thread-pool hop and recursion detection |
| `benchmarks/azure/` | Runs the benchmarks on Azure VMs, one per environment (`run.sh`); see `benchmarks/README.md` |
| `benchmarks/results/` | Results from the Azure VMs |

## Running

```bash
dotnet test
```

Benchmarks:

```bash
dotnet run -c Release --project benchmarks/AsyncLazy.Benchmarks -- --filter '*'
```

## How it works

All state lives in one field that is always exactly one of: nothing yet, a running attempt, or the value. Every transition is a single atomic write, so a value and a running attempt can never coexist and at most one attempt can start.

- **Fast path.** Once the value exists, `GetValueAsync` is a token check, one volatile read and a null check, and returns the same completed task every time. The fast path reads a typed copy of the completed task, because a type check on the state field costs a runtime generic lookup for reference types.
- **Attempts.** The factory runs on the thread pool, with the first caller's execution context but never its `SynchronizationContext` or `TaskScheduler`. Callers wait on the attempt through a task completion source; a caller's token cancels only its own wait.
- **Ordering.** When an attempt finishes, the new state is published *before* its waiters are released, so a waiter that resumes and calls again sees the value, or starts a new attempt after a failure.
- **Recursion and cycles.** Each attempt marks its asynchronous flow in an async-local chain. Joining an attempt from inside that same attempt, directly or through other instances, fails with `InvalidOperationException` (through the returned task) instead of hanging. The check only runs while no value exists.

## Known limitation

Releasing waiters *before* publishing the value is not caught. The race window is nanoseconds wide while a waiter needs microseconds to resume, so no black-box test can hit it reliably. The ordering is enforced by code review and documented in the code.

Recursion detection follows the execution context, not the await graph. Work that a factory starts *without awaiting* is still part of the attempt, so if that work calls `GetValueAsync` on the same instance before the attempt completes, the returned task faults instead of waiting. The same trade-off exists in `Microsoft.VisualStudio.Threading`'s `AsyncLazy<T>`. Such work can be started inside `ExecutionContext.SuppressFlow()` to wait normally, at the cost of every other async-local, including tracing. Detection is also best effort: a cycle whose instances were started by different callers still hangs.
