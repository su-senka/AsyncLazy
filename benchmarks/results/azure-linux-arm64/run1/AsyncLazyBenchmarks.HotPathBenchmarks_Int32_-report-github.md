```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.7099 ns | 0.0004 ns | 0.0004 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.3754 ns | 0.0002 ns | 0.0002 ns |  0.53 |    0.00 |      - |         - |          NA |
| Nito              | NoToken    | 25.0218 ns | 0.0026 ns | 0.0024 ns | 35.25 |    0.02 |      - |         - |          NA |
| VsThreading       | NoToken    | 15.2239 ns | 0.1287 ns | 0.1204 ns | 21.44 |    0.16 | 0.0024 |      40 B |          NA |
|                   |            |            |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.8533 ns | 0.0041 ns | 0.0039 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  0.3749 ns | 0.0004 ns | 0.0003 ns |  0.20 |    0.00 |      - |         - |          NA |
| Nito_Token        | Token      | 26.3059 ns | 0.1176 ns | 0.1100 ns | 14.19 |    0.06 |      - |         - |          NA |
| VsThreading_Token | Token      | 18.7013 ns | 0.0568 ns | 0.0504 ns | 10.09 |    0.03 | 0.0024 |      40 B |          NA |
