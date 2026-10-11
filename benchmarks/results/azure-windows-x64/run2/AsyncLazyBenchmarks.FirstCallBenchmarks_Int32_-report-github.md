```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Completed Work Items | Lock Contentions | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|----------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **41.26 ns** |  **0.359 ns** |  **0.336 ns** |  **1.00** |    **0.01** |                    **-** |                **-** |     **632 B** | **0.0017** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,274.22 ns | 12.571 ns | 11.759 ns | 30.88 |    0.37 |               1.0000 |                - |     756 B | 0.0019 |     288 B |        2.00 |
| AsyncLazy                      | Completed | 1,387.90 ns |  8.956 ns |  8.378 ns | 33.64 |    0.33 |               1.0000 |           0.0000 |   1,330 B | 0.0038 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   121.36 ns |  0.598 ns |  0.560 ns |  2.94 |    0.03 |                    - |                - |   3,059 B | 0.0050 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,347.03 ns | 12.663 ns | 11.226 ns | 32.65 |    0.37 |               1.0000 |                - |   2,490 B | 0.0038 |     352 B |        2.44 |
| Nito                           | Completed | 1,299.56 ns |  6.200 ns |  5.496 ns | 31.50 |    0.28 |               1.0000 |           0.0000 |   2,144 B | 0.0038 |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    61.44 ns |  0.382 ns |  0.357 ns |  1.49 |    0.01 |                    - |                - |     802 B | 0.0019 |     168 B |        1.17 |
| VsThreading                    | Completed |   224.64 ns |  0.698 ns |  0.653 ns |  5.44 |    0.05 |                    - |                - |   3,535 B | 0.0072 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |                      |                  |           |        |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,212.08 ns** | **10.428 ns** |  **9.754 ns** |  **1.00** |    **0.01** |               **1.0000** |                **-** |     **756 B** | **0.0019** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,089.45 ns |  7.993 ns |  7.086 ns |  1.72 |    0.01 |               2.0000 |           0.0000 |     756 B |      - |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 2,321.30 ns |  7.522 ns |  6.281 ns |  1.92 |    0.02 |               2.0785 |           0.0000 |   1,333 B | 0.0038 |     577 B |        3.43 |
| AsyncLazy_NoHop                | Yielding  | 1,521.43 ns | 14.969 ns | 14.002 ns |  1.26 |    0.01 |               1.0206 |           0.0000 |   2,877 B | 0.0057 |     574 B |        3.42 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,116.73 ns |  8.234 ns |  7.702 ns |  1.75 |    0.02 |               2.0501 |           0.0000 |   2,440 B | 0.0038 |     470 B |        2.80 |
| Nito                           | Yielding  | 2,045.17 ns |  7.978 ns |  7.072 ns |  1.69 |    0.01 |               2.0000 |           0.0000 |   2,151 B | 0.0038 |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,225.03 ns |  8.125 ns |  7.600 ns |  1.01 |    0.01 |               1.0000 |                - |   1,150 B | 0.0019 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,855.00 ns | 13.302 ns | 12.442 ns |  1.53 |    0.02 |               1.0000 |                - |   3,687 B | 0.0076 |     832 B |        4.95 |
