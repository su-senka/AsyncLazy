```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
Neoverse-N1, 8 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|----------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.6685 ns | 0.0004 ns | 0.0004 ns |  1.00 |    0.00 |      16 B |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.3341 ns | 0.0003 ns | 0.0002 ns |  0.50 |    0.00 |      16 B |      - |         - |          NA |
| Nito              | NoToken    | 25.3927 ns | 0.0419 ns | 0.0350 ns | 37.99 |    0.05 |      56 B |      - |         - |          NA |
| VsThreading       | NoToken    | 17.4520 ns | 0.0725 ns | 0.0679 ns | 26.11 |    0.10 |     140 B | 0.0024 |      40 B |          NA |
|                   |            |            |           |           |       |         |           |        |           |             |
| LazyOfTask_Token  | Token      |  1.0379 ns | 0.0005 ns | 0.0005 ns |  1.00 |    0.00 |      32 B |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.2037 ns | 0.0031 ns | 0.0029 ns |  1.16 |    0.00 |      44 B |      - |         - |          NA |
| Nito_Token        | Token      | 25.8578 ns | 0.0810 ns | 0.0758 ns | 24.91 |    0.07 |      72 B |      - |         - |          NA |
| VsThreading_Token | Token      | 20.1300 ns | 0.0627 ns | 0.0586 ns | 19.40 |    0.06 |     184 B | 0.0024 |      40 B |          NA |
