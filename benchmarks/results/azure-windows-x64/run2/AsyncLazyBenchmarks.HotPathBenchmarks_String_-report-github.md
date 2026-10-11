```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Code Size | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|----------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  0.9754 ns | 0.0149 ns | 0.0132 ns |  1.00 |    0.02 |     291 B |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.9408 ns | 0.0116 ns | 0.0103 ns |  0.96 |    0.02 |   1,798 B |      - |         - |          NA |
| Nito              | NoToken    | 18.6031 ns | 0.0632 ns | 0.0591 ns | 19.07 |    0.26 |     459 B |      - |         - |          NA |
| VsThreading       | NoToken    | 13.3812 ns | 0.0548 ns | 0.0486 ns | 13.72 |    0.19 |   1,411 B | 0.0005 |      40 B |          NA |
|                   |            |            |           |           |       |         |           |        |           |             |
| LazyOfTask_Token  | Token      |  1.6657 ns | 0.0190 ns | 0.0177 ns |  1.00 |    0.01 |     693 B |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.2759 ns | 0.0121 ns | 0.0113 ns |  0.77 |    0.01 |   2,079 B |      - |         - |          NA |
| Nito_Token        | Token      | 18.5793 ns | 0.0438 ns | 0.0410 ns | 11.16 |    0.12 |     848 B |      - |         - |          NA |
| VsThreading_Token | Token      | 13.6053 ns | 0.0282 ns | 0.0250 ns |  8.17 |    0.09 |   1,439 B | 0.0005 |      40 B |          NA |
