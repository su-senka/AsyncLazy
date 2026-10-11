```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Completed Work Items | Lock Contentions | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **40.84 ns** |  **0.136 ns** |  **0.127 ns** |  **1.00** |    **0.00** |                    **-** |                **-** | **0.0017** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,252.57 ns |  4.047 ns |  3.785 ns | 30.67 |    0.13 |               1.0000 |           0.0000 | 0.0019 |     288 B |        2.00 |
| AsyncLazy                      | Completed | 1,378.81 ns | 11.735 ns | 10.977 ns | 33.76 |    0.28 |               1.0000 |           0.0000 | 0.0038 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   117.09 ns |  0.462 ns |  0.432 ns |  2.87 |    0.01 |                    - |                - | 0.0050 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,402.08 ns | 15.661 ns | 14.649 ns | 34.33 |    0.36 |               1.0000 |                - | 0.0038 |     352 B |        2.44 |
| Nito                           | Completed | 1,318.04 ns |  5.333 ns |  4.988 ns | 32.27 |    0.15 |               1.0000 |                - | 0.0038 |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    61.29 ns |  0.114 ns |  0.106 ns |  1.50 |    0.01 |                    - |                - | 0.0019 |     168 B |        1.17 |
| VsThreading                    | Completed |   227.31 ns |  0.709 ns |  0.629 ns |  5.57 |    0.02 |                    - |                - | 0.0072 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |                      |                  |        |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,195.25 ns** |  **4.027 ns** |  **3.767 ns** |  **1.00** |    **0.00** |               **1.0000** |                **-** | **0.0019** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,003.10 ns | 11.996 ns | 11.221 ns |  1.68 |    0.01 |               2.0000 |           0.0000 |      - |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 2,365.04 ns |  7.705 ns |  7.207 ns |  1.98 |    0.01 |               2.0810 |           0.0000 | 0.0038 |     577 B |        3.43 |
| AsyncLazy_NoHop                | Yielding  | 1,568.75 ns |  8.489 ns |  7.941 ns |  1.31 |    0.01 |               1.0190 |           0.0000 | 0.0057 |     575 B |        3.42 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,089.80 ns | 14.075 ns | 11.753 ns |  1.75 |    0.01 |               2.0528 |           0.0000 | 0.0038 |     470 B |        2.80 |
| Nito                           | Yielding  | 2,149.05 ns | 30.775 ns | 28.787 ns |  1.80 |    0.02 |               2.0000 |                - | 0.0038 |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,236.69 ns |  8.158 ns |  7.631 ns |  1.03 |    0.01 |               1.0000 |           0.0000 | 0.0019 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,946.65 ns | 12.184 ns | 11.397 ns |  1.63 |    0.01 |               1.0000 |           0.0000 | 0.0076 |     832 B |        4.95 |
