```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|----------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.7095 ns | 0.0004 ns | 0.0003 ns |  1.00 |    0.00 |      16 B |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.3718 ns | 0.0002 ns | 0.0002 ns |  0.52 |    0.00 |      16 B |      - |         - |          NA |
| Nito              | NoToken    | 26.0953 ns | 0.1685 ns | 0.1576 ns | 36.78 |    0.22 |      56 B |      - |         - |          NA |
| VsThreading       | NoToken    | 17.0665 ns | 0.1107 ns | 0.1036 ns | 24.05 |    0.14 |     120 B | 0.0024 |      40 B |          NA |
|                   |            |            |           |           |       |         |           |        |           |             |
| LazyOfTask_Token  | Token      |  1.3775 ns | 0.0003 ns | 0.0003 ns |  1.00 |    0.00 |      28 B |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  0.7098 ns | 0.0003 ns | 0.0003 ns |  0.52 |    0.00 |      32 B |      - |         - |          NA |
| Nito_Token        | Token      | 25.9574 ns | 0.1389 ns | 0.1299 ns | 18.84 |    0.09 |      64 B |      - |         - |          NA |
| VsThreading_Token | Token      | 16.1047 ns | 0.0927 ns | 0.0867 ns | 11.69 |    0.06 |     164 B | 0.0024 |      40 B |          NA |
