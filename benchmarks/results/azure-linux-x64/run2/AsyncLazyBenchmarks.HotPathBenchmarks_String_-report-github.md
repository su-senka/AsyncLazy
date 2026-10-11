```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean      | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |----------:|----------:|----------:|------:|--------:|----------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.053 ns | 0.0654 ns | 0.0612 ns |  1.00 |    0.08 |     300 B |      - |         - |          NA |
| AsyncLazy         | NoToken    |  1.011 ns | 0.0759 ns | 0.0673 ns |  0.96 |    0.08 |   1,797 B |      - |         - |          NA |
| Nito              | NoToken    | 17.573 ns | 0.0438 ns | 0.0409 ns | 16.75 |    0.94 |     465 B |      - |         - |          NA |
| VsThreading       | NoToken    | 12.664 ns | 0.0283 ns | 0.0265 ns | 12.07 |    0.68 |   1,404 B | 0.0005 |      40 B |          NA |
|                   |            |           |           |           |       |         |           |        |           |             |
| LazyOfTask_Token  | Token      |  1.642 ns | 0.0457 ns | 0.0428 ns |  1.00 |    0.04 |     714 B |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.215 ns | 0.0271 ns | 0.0226 ns |  0.74 |    0.02 |   2,089 B |      - |         - |          NA |
| Nito_Token        | Token      | 18.897 ns | 0.0331 ns | 0.0276 ns | 11.51 |    0.30 |     950 B |      - |         - |          NA |
| VsThreading_Token | Token      | 12.998 ns | 0.0340 ns | 0.0318 ns |  7.92 |    0.21 |   1,430 B | 0.0005 |      40 B |          NA |
