```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Completed Work Items | Lock Contentions | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|-------:|---------------------:|-----------------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **43.82 ns** |  **0.172 ns** |  **0.161 ns** |  **1.00** |    **0.01** | **0.0017** |                    **-** |                **-** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,417.27 ns |  6.319 ns |  5.911 ns | 32.35 |    0.17 | 0.0019 |               1.0000 |           0.0000 |     296 B |        2.06 |
| AsyncLazy                      | Completed | 1,424.62 ns | 28.596 ns | 34.041 ns | 32.51 |    0.77 | 0.0038 |               1.0000 |           0.0000 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   136.97 ns |  0.580 ns |  0.542 ns |  3.13 |    0.02 | 0.0050 |                    - |                - |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,376.96 ns | 17.100 ns | 15.996 ns | 31.43 |    0.37 | 0.0038 |               1.0000 |                - |     352 B |        2.44 |
| Nito                           | Completed | 1,416.56 ns | 11.441 ns | 10.702 ns | 32.33 |    0.26 | 0.0038 |               1.0000 |           0.0000 |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |    64.42 ns |  0.199 ns |  0.176 ns |  1.47 |    0.01 | 0.0019 |                    - |                - |     168 B |        1.17 |
| VsThreading                    | Completed |   272.88 ns |  0.481 ns |  0.426 ns |  6.23 |    0.02 | 0.0072 |                    - |                - |     616 B |        4.28 |
|                                |           |             |           |           |       |         |        |                      |                  |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,332.95 ns** |  **4.606 ns** |  **4.308 ns** |  **1.00** |    **0.00** | **0.0019** |               **1.0000** |                **-** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,197.49 ns |  8.972 ns |  8.393 ns |  1.65 |    0.01 | 0.0038 |               2.0000 |                - |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 2,486.55 ns | 27.307 ns | 25.543 ns |  1.87 |    0.02 | 0.0038 |               2.0866 |           0.0000 |     587 B |        3.49 |
| AsyncLazy_NoHop                | Yielding  | 1,683.35 ns | 17.579 ns | 16.443 ns |  1.26 |    0.01 | 0.0057 |               1.0187 |           0.0000 |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,416.83 ns | 12.685 ns | 11.245 ns |  1.81 |    0.01 | 0.0038 |               2.0742 |                - |     466 B |        2.77 |
| Nito                           | Yielding  | 2,248.97 ns |  4.787 ns |  4.478 ns |  1.69 |    0.01 | 0.0038 |               2.0000 |                - |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,278.06 ns |  3.553 ns |  3.150 ns |  0.96 |    0.00 | 0.0019 |               1.0000 |                - |     192 B |        1.14 |
| VsThreading                    | Yielding  | 2,015.85 ns | 23.974 ns | 22.425 ns |  1.51 |    0.02 | 0.0076 |               1.0000 |                - |     832 B |        4.95 |
