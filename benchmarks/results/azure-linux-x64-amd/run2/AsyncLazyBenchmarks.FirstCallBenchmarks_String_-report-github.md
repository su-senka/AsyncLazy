```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|---------------------:|-----------------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **37.78 ns** |  **0.457 ns** |  **0.382 ns** |  **1.00** |    **0.01** |     **831 B** |                    **-** |                **-** | **0.0086** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed |   853.28 ns |  6.676 ns |  6.244 ns | 22.59 |    0.27 |     956 B |               1.0000 |                - | 0.0172 |     296 B |        2.06 |
| AsyncLazy                      | Completed |   900.09 ns |  2.480 ns |  2.319 ns | 23.83 |    0.24 |   2,127 B |               1.0000 |                - | 0.0267 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   112.44 ns |  1.134 ns |  1.061 ns |  2.98 |    0.04 |   2,055 B |                    - |                - | 0.0253 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed |   861.88 ns |  3.075 ns |  2.726 ns | 22.82 |    0.23 |   2,016 B |               1.0000 |                - | 0.0210 |     352 B |        2.44 |
| Nito                           | Completed |   860.06 ns |  3.077 ns |  2.728 ns | 22.77 |    0.23 |   2,613 B |               1.0000 |                - | 0.0238 |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |    52.18 ns |  0.585 ns |  0.488 ns |  1.38 |    0.02 |   1,060 B |                    - |                - | 0.0100 |     168 B |        1.17 |
| VsThreading                    | Completed |   249.87 ns |  1.552 ns |  1.375 ns |  6.62 |    0.07 |   4,663 B |                    - |                - | 0.0367 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |           |                      |                  |        |           |             |
| **LazyOfTask**                     | **Yielding**  |   **809.95 ns** |  **3.417 ns** |  **3.029 ns** |  **1.00** |    **0.01** |     **956 B** |               **1.0000** |                **-** | **0.0095** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 1,480.67 ns |  2.473 ns |  2.192 ns |  1.83 |    0.01 |     956 B |               2.0000 |                - | 0.0191 |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 1,714.33 ns |  5.721 ns |  5.352 ns |  2.12 |    0.01 |   2,133 B |               2.0253 |                - | 0.0362 |     607 B |        3.61 |
| AsyncLazy_NoHop                | Yielding  | 1,012.59 ns | 18.950 ns | 17.726 ns |  1.25 |    0.02 |   2,182 B |               1.0163 |                - | 0.0343 |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 1,633.86 ns |  5.082 ns |  4.754 ns |  2.02 |    0.01 |   2,016 B |               2.0458 |                - | 0.0286 |     493 B |        2.93 |
| Nito                           | Yielding  | 1,485.88 ns |  3.527 ns |  3.299 ns |  1.83 |    0.01 |   2,350 B |               2.0000 |                - | 0.0248 |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  |   816.60 ns |  3.959 ns |  3.703 ns |  1.01 |    0.01 |   1,280 B |               1.0000 |                - | 0.0114 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,291.43 ns | 25.364 ns | 40.958 ns |  1.59 |    0.05 |   4,807 B |               1.0000 |                - | 0.0496 |     832 B |        4.95 |
