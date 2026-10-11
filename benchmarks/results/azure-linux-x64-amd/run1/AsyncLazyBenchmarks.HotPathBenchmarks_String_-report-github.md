```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.9851 ns | 0.0027 ns | 0.0023 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.9733 ns | 0.0026 ns | 0.0024 ns |  0.99 |    0.00 |      - |         - |          NA |
| Nito              | NoToken    | 12.2068 ns | 0.0091 ns | 0.0081 ns | 12.39 |    0.03 |      - |         - |          NA |
| VsThreading       | NoToken    |  9.6891 ns | 0.1588 ns | 0.1485 ns |  9.84 |    0.15 | 0.0024 |      40 B |          NA |
|                   |            |            |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.9054 ns | 0.0009 ns | 0.0008 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.1678 ns | 0.0007 ns | 0.0006 ns |  0.61 |    0.00 |      - |         - |          NA |
| Nito_Token        | Token      | 10.8489 ns | 0.0063 ns | 0.0056 ns |  5.69 |    0.00 |      - |         - |          NA |
| VsThreading_Token | Token      |  9.7888 ns | 0.1354 ns | 0.1267 ns |  5.14 |    0.06 | 0.0024 |      40 B |          NA |
