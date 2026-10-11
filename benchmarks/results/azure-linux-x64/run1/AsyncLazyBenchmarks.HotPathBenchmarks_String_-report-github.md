```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.107 ns | 0.0570 ns | 0.0533 ns |  1.00 |    0.07 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  1.044 ns | 0.0745 ns | 0.0697 ns |  0.95 |    0.08 |      - |         - |          NA |
| Nito              | NoToken    | 17.753 ns | 0.0293 ns | 0.0260 ns | 16.07 |    0.75 |      - |         - |          NA |
| VsThreading       | NoToken    | 12.675 ns | 0.0439 ns | 0.0410 ns | 11.47 |    0.54 | 0.0005 |      40 B |          NA |
|                   |            |           |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.792 ns | 0.0680 ns | 0.0636 ns |  1.00 |    0.05 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.420 ns | 0.0536 ns | 0.0502 ns |  0.79 |    0.04 |      - |         - |          NA |
| Nito_Token        | Token      | 18.499 ns | 0.0248 ns | 0.0232 ns | 10.33 |    0.36 |      - |         - |          NA |
| VsThreading_Token | Token      | 12.686 ns | 0.0283 ns | 0.0265 ns |  7.09 |    0.25 | 0.0005 |      40 B |          NA |
