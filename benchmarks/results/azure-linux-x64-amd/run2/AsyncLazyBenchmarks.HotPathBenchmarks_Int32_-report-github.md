```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|----------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.9316 ns | 0.0048 ns | 0.0045 ns |  1.00 |    0.01 |     300 B |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.9002 ns | 0.0017 ns | 0.0015 ns |  0.97 |    0.00 |     856 B |      - |         - |          NA |
| Nito              | NoToken    | 10.3242 ns | 0.0051 ns | 0.0047 ns | 11.08 |    0.05 |     465 B |      - |         - |          NA |
| VsThreading       | NoToken    |  7.9040 ns | 0.1387 ns | 0.1297 ns |  8.48 |    0.14 |   1,033 B | 0.0024 |      40 B |          NA |
|                   |            |            |           |           |       |         |           |        |           |             |
| LazyOfTask_Token  | Token      |  1.3568 ns | 0.0014 ns | 0.0012 ns |  1.00 |    0.00 |     446 B |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.2245 ns | 0.0044 ns | 0.0041 ns |  0.90 |    0.00 |     907 B |      - |         - |          NA |
| Nito_Token        | Token      | 10.6701 ns | 0.0041 ns | 0.0036 ns |  7.86 |    0.01 |     592 B |      - |         - |          NA |
| VsThreading_Token | Token      |  8.7113 ns | 0.1800 ns | 0.1684 ns |  6.42 |    0.12 |   1,063 B | 0.0024 |      40 B |          NA |
