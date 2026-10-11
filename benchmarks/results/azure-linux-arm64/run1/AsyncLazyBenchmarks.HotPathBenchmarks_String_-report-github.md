```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.6681 ns | 0.0004 ns | 0.0003 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.3759 ns | 0.0002 ns | 0.0002 ns |  0.56 |    0.00 |      - |         - |          NA |
| Nito              | NoToken    | 24.8691 ns | 0.0036 ns | 0.0034 ns | 37.22 |    0.02 |      - |         - |          NA |
| VsThreading       | NoToken    | 16.7881 ns | 0.1311 ns | 0.1227 ns | 25.13 |    0.18 | 0.0024 |      40 B |          NA |
|                   |            |            |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.7254 ns | 0.0017 ns | 0.0016 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  0.7100 ns | 0.0004 ns | 0.0003 ns |  0.41 |    0.00 |      - |         - |          NA |
| Nito_Token        | Token      | 25.8793 ns | 0.0590 ns | 0.0552 ns | 15.00 |    0.03 |      - |         - |          NA |
| VsThreading_Token | Token      | 17.7866 ns | 0.0806 ns | 0.0754 ns | 10.31 |    0.04 | 0.0024 |      40 B |          NA |
