```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|---------------------:|-----------------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **45.30 ns** |  **0.088 ns** |  **0.082 ns** |  **1.00** |    **0.00** |     **831 B** |                    **-** |                **-** | **0.0017** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,368.68 ns |  4.675 ns |  4.373 ns | 30.22 |    0.11 |     956 B |               1.0000 |                - | 0.0019 |     296 B |        2.06 |
| AsyncLazy                      | Completed | 1,457.43 ns | 28.548 ns | 32.876 ns | 32.18 |    0.71 |   2,127 B |               1.0000 |                - | 0.0038 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   140.29 ns |  0.468 ns |  0.438 ns |  3.10 |    0.01 |   2,055 B |                    - |                - | 0.0050 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,401.15 ns | 19.992 ns | 18.700 ns | 30.93 |    0.40 |   2,016 B |               1.0000 |           0.0000 | 0.0038 |     352 B |        2.44 |
| Nito                           | Completed | 1,352.21 ns |  5.160 ns |  4.826 ns | 29.85 |    0.12 |   2,736 B |               1.0000 |           0.0000 | 0.0038 |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |    62.89 ns |  0.136 ns |  0.127 ns |  1.39 |    0.00 |   1,060 B |                    - |                - | 0.0019 |     168 B |        1.17 |
| VsThreading                    | Completed |   270.05 ns |  0.811 ns |  0.758 ns |  5.96 |    0.02 |   4,654 B |                    - |                - | 0.0072 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |           |                      |                  |        |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,355.64 ns** |  **8.218 ns** |  **7.687 ns** |  **1.00** |    **0.01** |     **956 B** |               **1.0000** |                **-** | **0.0019** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,348.69 ns |  9.067 ns |  8.038 ns |  1.73 |    0.01 |     956 B |               2.0000 |           0.0000 | 0.0038 |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 2,594.76 ns | 31.974 ns | 29.908 ns |  1.91 |    0.02 |   2,133 B |               2.0675 |                - | 0.0038 |     578 B |        3.44 |
| AsyncLazy_NoHop                | Yielding  | 1,663.59 ns | 24.328 ns | 22.756 ns |  1.23 |    0.02 |   2,182 B |               1.0204 |                - | 0.0057 |     575 B |        3.42 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,489.87 ns | 13.577 ns | 11.337 ns |  1.84 |    0.01 |   2,016 B |               2.0464 |                - | 0.0038 |     461 B |        2.74 |
| Nito                           | Yielding  | 2,146.28 ns | 10.276 ns |  9.110 ns |  1.58 |    0.01 |   2,823 B |               2.0000 |           0.0000 | 0.0038 |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,320.08 ns |  5.429 ns |  5.079 ns |  0.97 |    0.01 |   1,389 B |               1.0000 |                - | 0.0019 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,974.57 ns | 12.667 ns | 11.229 ns |  1.46 |    0.01 |   4,784 B |               1.0000 |                - | 0.0076 |     832 B |        4.95 |
