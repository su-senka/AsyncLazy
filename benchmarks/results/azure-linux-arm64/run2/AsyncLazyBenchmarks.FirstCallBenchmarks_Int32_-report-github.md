```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Completed Work Items | Lock Contentions | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|-------:|---------------------:|-----------------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **65.35 ns** |  **0.147 ns** |  **0.138 ns** |  **1.00** |    **0.00** |     **112 B** | **0.0086** |                    **-** |                **-** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,893.25 ns | 29.153 ns | 27.270 ns | 28.97 |    0.41 |     112 B | 0.0172 |               1.0000 |           0.0000 |     288 B |        2.00 |
| AsyncLazy                      | Completed | 1,994.75 ns | 39.230 ns | 77.436 ns | 30.53 |    1.18 |      72 B | 0.0267 |               1.0000 |                - |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   192.69 ns |  1.834 ns |  1.716 ns |  2.95 |    0.03 |     104 B | 0.0253 |                    - |                - |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,795.02 ns | 33.571 ns | 32.972 ns | 27.47 |    0.49 |      84 B | 0.0210 |               1.0000 |           0.0000 |     352 B |        2.44 |
| Nito                           | Completed | 1,998.20 ns | 39.166 ns | 56.170 ns | 30.58 |    0.85 |     244 B | 0.0229 |               1.0000 |                - |     400 B |        2.78 |
| Nito_ExecuteOnCallingThread    | Completed |    97.78 ns |  0.730 ns |  0.682 ns |  1.50 |    0.01 |     164 B | 0.0100 |                    - |                - |     168 B |        1.17 |
| VsThreading                    | Completed |   399.90 ns |  1.684 ns |  1.575 ns |  6.12 |    0.03 |     452 B | 0.0367 |                    - |                - |     616 B |        4.28 |
|                                |           |             |           |           |       |         |           |        |                      |                  |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,570.14 ns** | **29.933 ns** | **28.000 ns** |  **1.00** |    **0.02** |     **112 B** | **0.0076** |               **1.0000** |           **0.0000** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,992.43 ns | 43.106 ns | 40.322 ns |  1.91 |    0.04 |     112 B | 0.0153 |               2.0000 |           0.0000 |     312 B |        1.86 |
| AsyncLazy                      | Yielding  | 3,174.30 ns | 62.724 ns | 58.672 ns |  2.02 |    0.05 |      72 B | 0.0343 |               2.0914 |           0.0000 |     600 B |        3.57 |
| AsyncLazy_NoHop                | Yielding  | 2,080.66 ns | 36.002 ns | 33.676 ns |  1.33 |    0.03 |     100 B | 0.0343 |               1.0054 |                - |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 3,206.97 ns | 41.700 ns | 39.006 ns |  2.04 |    0.04 |      84 B | 0.0229 |               2.1597 |           0.0000 |     484 B |        2.88 |
| Nito                           | Yielding  | 2,912.49 ns | 35.093 ns | 32.826 ns |  1.86 |    0.04 |     244 B | 0.0229 |               2.0000 |           0.0000 |     424 B |        2.52 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,724.03 ns | 30.128 ns | 28.181 ns |  1.10 |    0.03 |     164 B | 0.0114 |               1.0000 |           0.0000 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 2,538.82 ns | 50.627 ns | 81.753 ns |  1.62 |    0.06 |     452 B | 0.0496 |               1.0000 |                - |     832 B |        4.95 |
