```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Completed Work Items | Lock Contentions | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|-------:|---------------------:|-----------------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **73.75 ns** |  **0.204 ns** |  **0.191 ns** |  **1.00** |    **0.00** | **0.0086** |                    **-** |                **-** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,904.16 ns | 29.313 ns | 27.420 ns | 25.82 |    0.37 | 0.0153 |               1.0000 |                - |     296 B |        2.06 |
| AsyncLazy                      | Completed | 2,030.21 ns | 15.831 ns | 14.808 ns | 27.53 |    0.21 | 0.0267 |               1.0000 |           0.0000 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   245.12 ns |  0.721 ns |  0.674 ns |  3.32 |    0.01 | 0.0253 |                    - |                - |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,823.73 ns | 36.227 ns | 40.266 ns | 24.73 |    0.54 | 0.0191 |               1.0000 |           0.0000 |     352 B |        2.44 |
| Nito                           | Completed | 1,921.01 ns | 37.644 ns | 36.972 ns | 26.05 |    0.49 | 0.0229 |               1.0000 |                - |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |   106.51 ns |  0.605 ns |  0.566 ns |  1.44 |    0.01 | 0.0100 |                    - |                - |     168 B |        1.17 |
| VsThreading                    | Completed |   470.85 ns |  1.352 ns |  1.129 ns |  6.38 |    0.02 | 0.0362 |                    - |                - |     616 B |        4.28 |
|                                |           |             |           |           |       |         |        |                      |                  |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,713.73 ns** | **15.702 ns** | **14.688 ns** |  **1.00** |    **0.01** | **0.0095** |               **1.0000** |                **-** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,838.47 ns | 35.509 ns | 33.215 ns |  1.66 |    0.02 | 0.0191 |               2.0000 |           0.0000 |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 3,167.67 ns | 51.455 ns | 48.131 ns |  1.85 |    0.03 | 0.0305 |               2.0591 |                - |     606 B |        3.61 |
| AsyncLazy_NoHop                | Yielding  | 2,201.39 ns | 43.455 ns | 46.496 ns |  1.28 |    0.03 | 0.0343 |               1.0050 |                - |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 3,189.25 ns | 31.149 ns | 29.137 ns |  1.86 |    0.02 | 0.0229 |               2.0869 |           0.0000 |     484 B |        2.88 |
| Nito                           | Yielding  | 2,896.28 ns | 27.532 ns | 25.754 ns |  1.69 |    0.02 | 0.0229 |               2.0000 |           0.0000 |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,681.68 ns | 23.148 ns | 19.330 ns |  0.98 |    0.01 | 0.0114 |               1.0000 |           0.0000 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 2,570.00 ns | 49.735 ns | 72.902 ns |  1.50 |    0.04 | 0.0496 |               1.0000 |           0.0000 |     832 B |        4.95 |
