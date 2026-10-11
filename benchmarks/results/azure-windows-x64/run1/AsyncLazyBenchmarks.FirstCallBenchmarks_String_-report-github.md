```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method                         | Factory   | Mean        | Error     | StdDev    | Ratio | RatioSD | Gen0   | Completed Work Items | Lock Contentions | Allocated | Alloc Ratio |
|------------------------------- |---------- |------------:|----------:|----------:|------:|--------:|-------:|---------------------:|-----------------:|----------:|------------:|
| **LazyOfTask**                     | **Completed** |    **41.12 ns** |  **0.200 ns** |  **0.187 ns** |  **1.00** |    **0.01** | **0.0017** |                    **-** |                **-** |     **144 B** |        **1.00** |
| LazyOfTask_TaskRun             | Completed | 1,299.66 ns | 19.394 ns | 18.141 ns | 31.61 |    0.45 | 0.0019 |               1.0000 |           0.0000 |     296 B |        2.06 |
| AsyncLazy                      | Completed | 1,406.97 ns | 11.269 ns | 10.541 ns | 34.22 |    0.29 | 0.0038 |               1.0000 |           0.0000 |     456 B |        3.17 |
| AsyncLazy_NoHop                | Completed |   127.64 ns |  0.659 ns |  0.584 ns |  3.10 |    0.02 | 0.0050 |                    - |                - |     424 B |        2.94 |
| AsyncLazy_NoRecursionDetection | Completed | 1,375.93 ns | 16.203 ns | 15.157 ns | 33.46 |    0.39 | 0.0038 |               1.0000 |                - |     352 B |        2.44 |
| Nito                           | Completed | 1,331.87 ns | 20.022 ns | 18.729 ns | 32.39 |    0.46 | 0.0038 |               1.0000 |           0.0000 |     408 B |        2.83 |
| Nito_ExecuteOnCallingThread    | Completed |    61.26 ns |  0.163 ns |  0.153 ns |  1.49 |    0.01 | 0.0019 |                    - |                - |     168 B |        1.17 |
| VsThreading                    | Completed |   248.36 ns |  0.802 ns |  0.670 ns |  6.04 |    0.03 | 0.0072 |                    - |                - |     616 B |        4.28 |
|                                |           |             |           |           |       |         |        |                      |                  |           |             |
| **LazyOfTask**                     | **Yielding**  | **1,239.87 ns** |  **5.739 ns** |  **5.368 ns** |  **1.00** |    **0.01** | **0.0019** |               **1.0000** |           **0.0000** |     **168 B** |        **1.00** |
| LazyOfTask_TaskRun             | Yielding  | 2,053.47 ns |  8.920 ns |  8.344 ns |  1.66 |    0.01 | 0.0038 |               2.0000 |           0.0000 |     320 B |        1.90 |
| AsyncLazy                      | Yielding  | 2,412.11 ns | 14.108 ns | 13.196 ns |  1.95 |    0.01 | 0.0038 |               2.0762 |           0.0000 |     584 B |        3.48 |
| AsyncLazy_NoHop                | Yielding  | 1,621.56 ns | 32.279 ns | 34.538 ns |  1.31 |    0.03 | 0.0057 |               1.0198 |           0.0000 |     575 B |        3.42 |
| AsyncLazy_NoRecursionDetection | Yielding  | 2,319.18 ns |  7.734 ns |  7.235 ns |  1.87 |    0.01 | 0.0038 |               2.0497 |           0.0000 |     474 B |        2.82 |
| Nito                           | Yielding  | 2,209.04 ns | 39.814 ns | 37.242 ns |  1.78 |    0.03 | 0.0038 |               2.0000 |           0.0000 |     432 B |        2.57 |
| Nito_ExecuteOnCallingThread    | Yielding  | 1,263.98 ns | 10.623 ns |  8.871 ns |  1.02 |    0.01 | 0.0019 |               1.0000 |           0.0000 |     192 B |        1.14 |
| VsThreading                    | Yielding  | 1,909.56 ns | 18.825 ns | 17.609 ns |  1.54 |    0.02 | 0.0076 |               1.0000 |           0.0000 |     832 B |        4.95 |
