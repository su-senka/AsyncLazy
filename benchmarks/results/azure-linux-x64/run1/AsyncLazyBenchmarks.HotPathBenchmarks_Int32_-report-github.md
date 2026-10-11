```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.131 ns | 0.0929 ns | 0.0869 ns |  1.01 |    0.11 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  1.176 ns | 0.0870 ns | 0.0814 ns |  1.05 |    0.11 |      - |         - |          NA |
| Nito              | NoToken    | 17.579 ns | 0.0370 ns | 0.0346 ns | 15.64 |    1.27 |      - |         - |          NA |
| VsThreading       | NoToken    | 12.319 ns | 0.0342 ns | 0.0303 ns | 10.96 |    0.89 | 0.0005 |      40 B |          NA |
|                   |            |           |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.750 ns | 0.0747 ns | 0.0699 ns |  1.00 |    0.05 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.373 ns | 0.0603 ns | 0.0564 ns |  0.79 |    0.04 |      - |         - |          NA |
| Nito_Token        | Token      | 18.251 ns | 0.0364 ns | 0.0340 ns | 10.44 |    0.40 |      - |         - |          NA |
| VsThreading_Token | Token      | 12.297 ns | 0.0460 ns | 0.0430 ns |  7.04 |    0.27 | 0.0005 |      40 B |          NA |
