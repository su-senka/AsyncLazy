```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.2713 ns | 0.0208 ns | 0.0174 ns |  1.00 |    0.02 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  1.0080 ns | 0.0417 ns | 0.0390 ns |  0.79 |    0.03 |      - |         - |          NA |
| Nito              | NoToken    | 18.6010 ns | 0.0455 ns | 0.0404 ns | 14.63 |    0.20 |      - |         - |          NA |
| VsThreading       | NoToken    | 12.6149 ns | 0.0367 ns | 0.0326 ns |  9.92 |    0.13 | 0.0005 |      40 B |          NA |
|                   |            |            |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.7005 ns | 0.0488 ns | 0.0457 ns |  1.00 |    0.04 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  0.9166 ns | 0.0237 ns | 0.0210 ns |  0.54 |    0.02 |      - |         - |          NA |
| Nito_Token        | Token      | 18.7080 ns | 0.0521 ns | 0.0487 ns | 11.01 |    0.28 |      - |         - |          NA |
| VsThreading_Token | Token      | 12.6408 ns | 0.0587 ns | 0.0549 ns |  7.44 |    0.19 | 0.0005 |      40 B |          NA |
