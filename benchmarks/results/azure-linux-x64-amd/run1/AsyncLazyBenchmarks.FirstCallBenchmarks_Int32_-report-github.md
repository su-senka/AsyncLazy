```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Completed Work Items | Lock Contentions | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **33.58 ns** |  **0.432 ns** |  **0.360 ns** |  **1.00** |    **0.01** |                    **-** |                **-** | **0.0086** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed |   812.34 ns |  2.895 ns |  2.708 ns | 24.19 |    0.26 |               1.0000 |                - | 0.0172 |     288 B |        2.00 |
| AsyncLazy                      | Completed |   876.63 ns |  2.711 ns |  2.536 ns | 26.11 |    0.28 |               1.0000 |           0.0000 | 0.0267 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   105.49 ns |  1.297 ns |  1.213 ns |  3.14 |    0.05 |                    - |                - | 0.0253 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed |   838.64 ns |  3.094 ns |  2.895 ns | 24.97 |    0.27 |               1.0000 |                - | 0.0210 |     352 B |        2.44 |
| Nito                           | Completed |   840.55 ns |  2.641 ns |  2.471 ns | 25.03 |    0.27 |               1.0000 |                - | 0.0238 |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    50.52 ns |  0.442 ns |  0.414 ns |  1.50 |    0.02 |                    - |                - | 0.0100 |     168 B |        1.17 |
| VsThreading                    | Completed |   226.43 ns |  1.909 ns |  1.594 ns |  6.74 |    0.08 |                    - |                - | 0.0367 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |                      |                  |        |           |             |
| **LazyOfTask**                     | **Yielding**  |   **790.80 ns** |  **1.847 ns** |  **1.637 ns** |  **1.00** |    **0.00** |               **1.0000** |                **-** | **0.0095** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 1,448.55 ns |  9.836 ns |  9.201 ns |  1.83 |    0.01 |               2.0000 |                - | 0.0172 |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 1,643.93 ns |  8.475 ns |  7.927 ns |  2.08 |    0.01 |               2.0331 |                - | 0.0362 |     606 B |        3.61 |
| AsyncLazy_NoHop                | Yielding  |   966.71 ns | 19.081 ns | 19.595 ns |  1.22 |    0.02 |               1.0164 |                - | 0.0343 |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 1,562.22 ns |  4.817 ns |  4.270 ns |  1.98 |    0.01 |               2.0600 |                - | 0.0267 |     488 B |        2.90 |
| Nito                           | Yielding  | 1,465.67 ns |  5.546 ns |  5.188 ns |  1.85 |    0.01 |               2.0000 |                - | 0.0248 |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  |   780.65 ns |  2.072 ns |  1.938 ns |  0.99 |    0.00 |               1.0000 |                - | 0.0114 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,268.11 ns | 25.067 ns | 25.742 ns |  1.60 |    0.03 |               1.0000 |                - | 0.0496 |     832 B |        4.95 |
