```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|----------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.0148 ns | 0.0672 ns | 0.0628 ns |  1.00 |    0.09 |     300 B |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.9712 ns | 0.0359 ns | 0.0300 ns |  0.96 |    0.07 |     853 B |      - |         - |          NA |
| Nito              | NoToken    | 17.5394 ns | 0.0420 ns | 0.0393 ns | 17.35 |    1.09 |     560 B |      - |         - |          NA |
| VsThreading       | NoToken    | 12.0047 ns | 0.0310 ns | 0.0275 ns | 11.87 |    0.75 |   1,033 B | 0.0005 |      40 B |          NA |
|                   |            |            |           |           |       |         |           |        |           |             |
| LazyOfTask_Token  | Token      |  1.6792 ns | 0.0491 ns | 0.0459 ns |  1.00 |    0.04 |     446 B |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.3706 ns | 0.0431 ns | 0.0403 ns |  0.82 |    0.03 |     904 B |      - |         - |          NA |
| Nito_Token        | Token      | 18.4561 ns | 0.1635 ns | 0.1530 ns | 11.00 |    0.31 |     592 B |      - |         - |          NA |
| VsThreading_Token | Token      | 12.2441 ns | 0.0324 ns | 0.0303 ns |  7.30 |    0.19 |   1,063 B | 0.0005 |      40 B |          NA |
