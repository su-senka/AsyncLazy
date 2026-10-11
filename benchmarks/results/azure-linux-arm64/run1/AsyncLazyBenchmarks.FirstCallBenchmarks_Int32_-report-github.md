```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Completed Work Items | Lock Contentions | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|---------------------:|-----------------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **69.44 ns** |  **0.279 ns** |  **0.247 ns** |  **1.00** |    **0.00** |                    **-** |                **-** | **0.0086** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,866.51 ns | 28.394 ns | 26.560 ns | 26.88 |    0.38 |               1.0000 |                - | 0.0172 |     288 B |        2.00 |
| AsyncLazy                      | Completed | 1,861.12 ns | 36.319 ns | 47.226 ns | 26.80 |    0.67 |               1.0000 |           0.0000 | 0.0267 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   215.65 ns |  0.777 ns |  0.727 ns |  3.11 |    0.01 |                    - |                - | 0.0253 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,798.02 ns | 35.746 ns | 57.722 ns | 25.89 |    0.82 |               1.0000 |           0.0000 | 0.0210 |     352 B |        2.44 |
| Nito                           | Completed | 1,904.64 ns | 35.409 ns | 36.362 ns | 27.43 |    0.52 |               1.0000 |                - | 0.0229 |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    98.13 ns |  0.182 ns |  0.152 ns |  1.41 |    0.01 |                    - |                - | 0.0100 |     168 B |        1.17 |
| VsThreading                    | Completed |   397.99 ns |  1.332 ns |  1.246 ns |  5.73 |    0.03 |                    - |                - | 0.0367 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |                      |                  |        |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,650.43 ns** | **32.181 ns** | **33.047 ns** |  **1.00** |    **0.03** |               **1.0000** |                **-** | **0.0095** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,980.42 ns | 28.026 ns | 26.215 ns |  1.81 |    0.04 |               2.0000 |           0.0000 | 0.0153 |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 3,093.04 ns | 60.946 ns | 57.009 ns |  1.87 |    0.05 |               2.0602 |           0.0000 | 0.0343 |     602 B |        3.58 |
| AsyncLazy_NoHop                | Yielding  | 2,093.66 ns | 34.651 ns | 32.412 ns |  1.27 |    0.03 |               1.0050 |                - | 0.0343 |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,965.75 ns | 32.621 ns | 30.514 ns |  1.80 |    0.04 |               2.1308 |           0.0000 | 0.0229 |     486 B |        2.89 |
| Nito                           | Yielding  | 2,921.71 ns | 50.532 ns | 47.267 ns |  1.77 |    0.04 |               2.0000 |           0.0000 | 0.0229 |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,766.33 ns | 17.572 ns | 16.437 ns |  1.07 |    0.02 |               1.0000 |           0.0000 | 0.0114 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 2,570.88 ns | 39.299 ns | 36.760 ns |  1.56 |    0.04 |               1.0000 |                - | 0.0458 |     832 B |        4.95 |
