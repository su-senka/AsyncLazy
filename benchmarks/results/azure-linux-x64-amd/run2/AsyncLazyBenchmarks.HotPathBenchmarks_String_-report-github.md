```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|----------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.8950 ns | 0.0010 ns | 0.0009 ns |  1.00 |    0.00 |     300 B |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.9721 ns | 0.0007 ns | 0.0006 ns |  1.09 |    0.00 |   1,812 B |      - |         - |          NA |
| Nito              | NoToken    | 10.4300 ns | 0.0036 ns | 0.0034 ns | 11.65 |    0.01 |     465 B |      - |         - |          NA |
| VsThreading       | NoToken    |  9.7651 ns | 0.1923 ns | 0.1799 ns | 10.91 |    0.19 |   1,404 B | 0.0024 |      40 B |          NA |
|                   |            |            |           |           |       |         |           |        |           |             |
| LazyOfTask_Token  | Token      |  1.9060 ns | 0.0008 ns | 0.0007 ns |  1.00 |    0.00 |     714 B |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.1654 ns | 0.0008 ns | 0.0007 ns |  0.61 |    0.00 |   2,104 B |      - |         - |          NA |
| Nito_Token        | Token      | 10.7310 ns | 0.0069 ns | 0.0064 ns |  5.63 |    0.00 |     855 B |      - |         - |          NA |
| VsThreading_Token | Token      |  9.8895 ns | 0.1716 ns | 0.1605 ns |  5.19 |    0.08 |   1,430 B | 0.0024 |      40 B |          NA |
