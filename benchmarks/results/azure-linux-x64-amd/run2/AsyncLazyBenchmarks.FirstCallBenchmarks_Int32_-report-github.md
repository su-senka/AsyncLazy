```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Completed Work Items | Lock Contentions | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|-------:|---------------------:|-----------------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **33.88 ns** |  **0.329 ns** |  **0.308 ns** |  **1.00** |    **0.01** |     **619 B** | **0.0086** |                    **-** |                **-** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed |   862.61 ns |  1.998 ns |  1.869 ns | 25.46 |    0.23 |     744 B | 0.0172 |               1.0000 |                - |     288 B |        2.00 |
| AsyncLazy                      | Completed |   871.85 ns |  2.703 ns |  2.528 ns | 25.73 |    0.24 |   1,357 B | 0.0267 |               1.0000 |                - |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   105.03 ns |  0.762 ns |  0.676 ns |  3.10 |    0.03 |   3,122 B | 0.0253 |                    - |                - |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed |   832.17 ns |  2.328 ns |  2.063 ns | 24.56 |    0.22 |   2,516 B | 0.0210 |               1.0000 |                - |     352 B |        2.44 |
| Nito                           | Completed |   867.42 ns |  5.749 ns |  5.378 ns | 25.60 |    0.27 |   1,978 B | 0.0238 |               1.0000 |                - |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    47.02 ns |  0.283 ns |  0.221 ns |  1.39 |    0.01 |     791 B | 0.0100 |                    - |                - |     168 B |        1.17 |
| VsThreading                    | Completed |   232.49 ns |  1.786 ns |  1.670 ns |  6.86 |    0.08 |   3,758 B | 0.0367 |                    - |                - |     616 B |        4.28 |
|                                |           |             |           |           |       |         |           |        |                      |                  |           |             |
| **LazyOfTask**                     | **Yielding**  |   **790.36 ns** |  **1.921 ns** |  **1.703 ns** |  **1.00** |    **0.00** |     **744 B** | **0.0095** |               **1.0000** |                **-** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 1,438.43 ns |  3.215 ns |  2.850 ns |  1.82 |    0.01 |     744 B | 0.0172 |               2.0000 |                - |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 1,654.84 ns |  6.297 ns |  5.891 ns |  2.09 |    0.01 |   1,360 B | 0.0362 |               2.0417 |                - |     605 B |        3.60 |
| AsyncLazy_NoHop                | Yielding  |   972.00 ns |  7.446 ns |  6.217 ns |  1.23 |    0.01 |   2,923 B | 0.0343 |               1.0164 |                - |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 1,588.08 ns |  4.417 ns |  3.916 ns |  2.01 |    0.01 |   2,472 B | 0.0286 |               2.0540 |                - |     490 B |        2.92 |
| Nito                           | Yielding  | 1,433.97 ns |  4.602 ns |  4.305 ns |  1.81 |    0.01 |   1,985 B | 0.0248 |               2.0000 |                - |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  |   815.29 ns |  2.200 ns |  2.058 ns |  1.03 |    0.00 |     916 B | 0.0114 |               1.0000 |                - |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,216.10 ns | 18.495 ns | 16.396 ns |  1.54 |    0.02 |   3,913 B | 0.0496 |               1.0000 |                - |     832 B |        4.95 |
