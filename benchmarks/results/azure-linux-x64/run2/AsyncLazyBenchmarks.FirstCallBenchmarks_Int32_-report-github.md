```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Completed Work Items | Lock Contentions | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|-------:|---------------------:|-----------------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **41.08 ns** |  **0.086 ns** |  **0.080 ns** |  **1.00** |    **0.00** |     **619 B** | **0.0017** |                    **-** |                **-** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,250.71 ns |  6.658 ns |  6.228 ns | 30.45 |    0.16 |     744 B | 0.0019 |               1.0000 |                - |     288 B |        2.00 |
| AsyncLazy                      | Completed | 1,430.79 ns | 11.315 ns | 10.031 ns | 34.83 |    0.24 |   1,357 B | 0.0038 |               1.0000 |           0.0000 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   128.14 ns |  0.382 ns |  0.358 ns |  3.12 |    0.01 |   3,122 B | 0.0050 |                    - |                - |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,380.08 ns |  9.267 ns |  8.669 ns | 33.60 |    0.21 |   2,518 B | 0.0038 |               1.0000 |           0.0000 |     352 B |        2.44 |
| Nito                           | Completed | 1,355.32 ns |  6.926 ns |  6.478 ns | 32.99 |    0.16 |   2,087 B | 0.0038 |               1.0000 |                - |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    62.89 ns |  0.158 ns |  0.148 ns |  1.53 |    0.00 |     791 B | 0.0019 |                    - |                - |     168 B |        1.17 |
| VsThreading                    | Completed |   259.96 ns |  0.498 ns |  0.389 ns |  6.33 |    0.02 |   3,746 B | 0.0072 |                    - |                - |     616 B |        4.28 |
|                                |           |             |           |           |       |         |           |        |                      |                  |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,224.53 ns** |  **5.569 ns** |  **5.209 ns** |  **1.00** |    **0.01** |     **744 B** | **0.0019** |               **1.0000** |           **0.0000** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,144.68 ns |  6.848 ns |  6.406 ns |  1.75 |    0.01 |     744 B |      - |               2.0000 |                - |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 2,441.12 ns | 17.979 ns | 16.818 ns |  1.99 |    0.02 |   1,360 B | 0.0038 |               2.0746 |           0.0000 |     577 B |        3.43 |
| AsyncLazy_NoHop                | Yielding  | 1,622.58 ns | 20.418 ns | 19.099 ns |  1.33 |    0.02 |   2,930 B | 0.0057 |               1.0214 |                - |     574 B |        3.42 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,299.30 ns | 18.402 ns | 17.213 ns |  1.88 |    0.02 |   2,511 B | 0.0038 |               2.0553 |                - |     464 B |        2.76 |
| Nito                           | Yielding  | 2,287.58 ns |  8.698 ns |  8.136 ns |  1.87 |    0.01 |   2,094 B | 0.0038 |               2.0000 |                - |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,288.57 ns |  5.602 ns |  5.241 ns |  1.05 |    0.01 |   1,011 B | 0.0019 |               1.0000 |                - |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,930.15 ns | 13.547 ns | 12.671 ns |  1.58 |    0.01 |   3,901 B | 0.0076 |               1.0000 |                - |     832 B |        4.95 |
