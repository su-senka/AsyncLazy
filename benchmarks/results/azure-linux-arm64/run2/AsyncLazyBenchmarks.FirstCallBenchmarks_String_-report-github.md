```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Code Size | Completed Work Items | Lock Contentions | Gen0   | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|----------:|---------------------:|-----------------:|-------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **90.67 ns** |  **0.153 ns** |  **0.128 ns** |  **1.00** |    **0.00** |     **128 B** |                    **-** |                **-** | **0.0086** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,957.66 ns | 32.865 ns | 30.742 ns | 21.59 |    0.33 |     128 B |               1.0000 |                - | 0.0153 |     296 B |        2.06 |
| AsyncLazy                      | Completed | 1,991.96 ns | 18.192 ns | 17.017 ns | 21.97 |    0.18 |      88 B |               1.0000 |                - | 0.0267 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   205.16 ns |  0.856 ns |  0.801 ns |  2.26 |    0.01 |     120 B |                    - |                - | 0.0253 |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,821.36 ns | 19.281 ns | 18.035 ns | 20.09 |    0.19 |      88 B |               1.0000 |                - | 0.0210 |     352 B |        2.44 |
| Nito                           | Completed | 1,901.08 ns | 29.581 ns | 27.670 ns | 20.97 |    0.30 |     292 B |               1.0000 |           0.0000 | 0.0229 |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |   104.70 ns |  0.564 ns |  0.528 ns |  1.15 |    0.01 |     200 B |                    - |                - | 0.0100 |     168 B |        1.17 |
| VsThreading                    | Completed |   508.69 ns |  1.682 ns |  1.573 ns |  5.61 |    0.02 |     748 B |                    - |                - | 0.0362 |     616 B |        4.28 |
|                                |           |             |           |           |       |         |           |                      |                  |        |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,704.82 ns** | **33.561 ns** | **32.961 ns** |  **1.00** |    **0.03** |     **128 B** |               **1.0000** |                **-** | **0.0095** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,996.72 ns | 59.820 ns | 71.211 ns |  1.76 |    0.05 |     128 B |               2.0000 |           0.0000 | 0.0191 |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 3,275.66 ns | 40.968 ns | 38.321 ns |  1.92 |    0.04 |      88 B |               2.0682 |                - | 0.0305 |     605 B |        3.60 |
| AsyncLazy_NoHop                | Yielding  | 2,186.24 ns | 25.278 ns | 23.645 ns |  1.28 |    0.03 |     120 B |               1.0060 |                - | 0.0343 |     576 B |        3.43 |
| AsyncLazy_NoRecursionDetection | Yielding  | 3,200.27 ns | 38.541 ns | 36.052 ns |  1.88 |    0.04 |      88 B |               2.0777 |           0.0000 | 0.0229 |     493 B |        2.93 |
| Nito                           | Yielding  | 2,903.03 ns | 20.162 ns | 16.837 ns |  1.70 |    0.03 |     292 B |               2.0000 |           0.0000 | 0.0229 |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,663.46 ns |  8.687 ns |  7.701 ns |  0.98 |    0.02 |     200 B |               1.0000 |           0.0000 | 0.0114 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 2,561.33 ns | 49.886 ns | 79.125 ns |  1.50 |    0.05 |     748 B |               1.0000 |                - | 0.0496 |     832 B |        4.95 |
