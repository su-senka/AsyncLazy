```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Completed Work Items | Lock Contentions | Code Size | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|-------:|---------------------:|-----------------:|----------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **41.00 ns** |  **0.169 ns** |  **0.158 ns** |  **1.00** |    **0.01** | **0.0017** |                    **-** |                **-** |     **837 B** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,269.94 ns |  3.261 ns |  2.891 ns | 30.98 |    0.13 | 0.0019 |               1.0000 |                - |     961 B |     296 B |        2.06 |
| AsyncLazy                      | Completed | 1,400.00 ns | 10.695 ns | 10.004 ns | 34.15 |    0.27 | 0.0038 |               1.0000 |                - |   2,084 B |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   124.10 ns |  0.721 ns |  0.639 ns |  3.03 |    0.02 | 0.0050 |                    - |                - |   2,070 B |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,346.41 ns | 21.929 ns | 20.512 ns | 32.84 |    0.50 | 0.0038 |               1.0000 |           0.0000 |   1,973 B |     352 B |        2.44 |
| Nito                           | Completed | 1,317.60 ns |  6.025 ns |  5.031 ns | 32.14 |    0.17 | 0.0038 |               1.0000 |                - |   2,778 B |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |    60.93 ns |  0.169 ns |  0.158 ns |  1.49 |    0.01 | 0.0019 |                    - |                - |   1,075 B |     168 B |        1.17 |
| VsThreading                    | Completed |   251.11 ns |  1.023 ns |  0.957 ns |  6.12 |    0.03 | 0.0072 |                    - |                - |   4,421 B |     616 B |        4.28 |
|                                |           |             |           |           |       |         |        |                      |                  |           |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,232.30 ns** |  **4.796 ns** |  **4.486 ns** |  **1.00** |    **0.00** | **0.0019** |               **1.0000** |                **-** |     **961 B** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,034.06 ns |  6.513 ns |  5.773 ns |  1.65 |    0.01 | 0.0038 |               2.0000 |           0.0000 |     961 B |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 2,370.23 ns | 10.349 ns |  9.174 ns |  1.92 |    0.01 | 0.0038 |               2.0697 |           0.0000 |   2,084 B |     584 B |        3.48 |
| AsyncLazy_NoHop                | Yielding  | 1,524.31 ns | 16.812 ns | 15.726 ns |  1.24 |    0.01 | 0.0057 |               1.0186 |                - |   2,196 B |     575 B |        3.42 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,283.50 ns | 19.302 ns | 18.055 ns |  1.85 |    0.02 | 0.0038 |               2.0405 |           0.0000 |   1,973 B |     474 B |        2.82 |
| Nito                           | Yielding  | 2,106.40 ns |  7.763 ns |  6.882 ns |  1.71 |    0.01 | 0.0038 |               2.0000 |                - |   2,518 B |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,255.35 ns |  5.870 ns |  4.902 ns |  1.02 |    0.01 | 0.0019 |               1.0000 |                - |   1,423 B |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,905.61 ns | 14.252 ns | 13.332 ns |  1.55 |    0.01 | 0.0076 |               1.0000 |                - |   4,557 B |     832 B |        4.95 |
