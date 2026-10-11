```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Completed Work Items | Lock Contentions | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|-------:|---------------------:|-----------------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **37.45 ns** |  **0.394 ns** |  **0.349 ns** |  **1.00** |    **0.01** | **0.0086** |                    **-** |                **-** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed |   828.98 ns |  3.549 ns |  3.146 ns | 22.14 |    0.22 | 0.0172 |               1.0000 |                - |     296 B |        2.06 |
| AsyncLazy                      | Completed |   943.08 ns |  1.907 ns |  1.690 ns | 25.18 |    0.23 | 0.0267 |               1.0000 |                - |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   113.43 ns |  0.577 ns |  0.512 ns |  3.03 |    0.03 | 0.0253 |                    - |                - |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed |   844.97 ns |  3.077 ns |  2.879 ns | 22.56 |    0.22 | 0.0210 |               1.0000 |                - |     352 B |        2.44 |
| Nito                           | Completed |   863.42 ns |  4.250 ns |  3.976 ns | 23.06 |    0.23 | 0.0238 |               1.0000 |                - |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |    52.59 ns |  0.784 ns |  0.734 ns |  1.40 |    0.02 | 0.0100 |                    - |                - |     168 B |        1.17 |
| VsThreading                    | Completed |   252.90 ns |  1.281 ns |  1.136 ns |  6.75 |    0.07 | 0.0367 |                    - |                - |     616 B |        4.28 |
|                                |           |             |           |           |       |         |        |                      |                  |           |             |
| **LazyOfTask**                     | **Yielding**  |   **819.94 ns** |  **1.756 ns** |  **1.642 ns** |  **1.00** |    **0.00** | **0.0095** |               **1.0000** |                **-** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 1,465.98 ns |  3.478 ns |  3.083 ns |  1.79 |    0.01 | 0.0191 |               2.0000 |                - |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 1,686.18 ns |  2.827 ns |  2.644 ns |  2.06 |    0.01 | 0.0362 |               2.0340 |                - |     607 B |        3.61 |
| AsyncLazy_NoHop                | Yielding  | 1,002.08 ns | 17.905 ns | 16.748 ns |  1.22 |    0.02 | 0.0343 |               1.0163 |                - |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 1,661.97 ns |  3.834 ns |  3.586 ns |  2.03 |    0.01 | 0.0286 |               2.0539 |                - |     493 B |        2.93 |
| Nito                           | Yielding  | 1,495.00 ns |  2.897 ns |  2.568 ns |  1.82 |    0.00 | 0.0248 |               2.0000 |                - |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  |   814.31 ns |  4.523 ns |  4.231 ns |  0.99 |    0.01 | 0.0114 |               1.0000 |                - |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,274.06 ns | 24.922 ns | 45.571 ns |  1.55 |    0.06 | 0.0496 |               1.0000 |                - |     832 B |        4.95 |
