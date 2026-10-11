```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Completed Work Items | Lock Contentions | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **42.02 ns** |  **0.064 ns** |  **0.060 ns** |  **1.00** |    **0.00** |                    **-** |                **-** | **0.0017** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,274.72 ns |  4.579 ns |  4.283 ns | 30.33 |    0.11 |               1.0000 |                - | 0.0019 |     288 B |        2.00 |
| AsyncLazy                      | Completed | 1,406.53 ns | 15.930 ns | 14.901 ns | 33.47 |    0.35 |               1.0000 |           0.0000 | 0.0038 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   132.53 ns |  0.314 ns |  0.294 ns |  3.15 |    0.01 |                    - |                - | 0.0050 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,346.43 ns | 21.550 ns | 20.158 ns | 32.04 |    0.47 |               1.0000 |                - | 0.0038 |     352 B |        2.44 |
| Nito                           | Completed | 1,382.65 ns |  5.517 ns |  5.161 ns | 32.90 |    0.13 |               1.0000 |           0.0000 | 0.0038 |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    63.30 ns |  0.194 ns |  0.182 ns |  1.51 |    0.00 |                    - |                - | 0.0019 |     168 B |        1.17 |
| VsThreading                    | Completed |   257.99 ns |  0.530 ns |  0.495 ns |  6.14 |    0.01 |                    - |                - | 0.0072 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |                      |                  |        |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,292.50 ns** |  **2.873 ns** |  **2.688 ns** |  **1.00** |    **0.00** |               **1.0000** |                **-** | **0.0019** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,085.51 ns |  6.487 ns |  6.068 ns |  1.61 |    0.01 |               2.0000 |                - |      - |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 2,417.75 ns | 16.902 ns | 15.810 ns |  1.87 |    0.01 |               2.0900 |                - | 0.0038 |     590 B |        3.51 |
| AsyncLazy_NoHop                | Yielding  | 1,752.82 ns | 33.722 ns | 36.083 ns |  1.36 |    0.03 |               1.0182 |                - | 0.0038 |     575 B |        3.42 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,286.73 ns | 15.861 ns | 14.837 ns |  1.77 |    0.01 |               2.0789 |                - | 0.0038 |     472 B |        2.81 |
| Nito                           | Yielding  | 2,213.90 ns | 12.416 ns | 11.614 ns |  1.71 |    0.01 |               2.0000 |                - | 0.0038 |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,397.61 ns |  8.331 ns |  7.793 ns |  1.08 |    0.01 |               1.0000 |                - | 0.0019 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,889.00 ns |  7.389 ns |  6.911 ns |  1.46 |    0.01 |               1.0000 |           0.0000 | 0.0076 |     832 B |        4.95 |
