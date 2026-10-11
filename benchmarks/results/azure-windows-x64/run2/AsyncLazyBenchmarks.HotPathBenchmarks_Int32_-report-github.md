```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Code Size | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.0079 ns | 0.0454 ns | 0.0425 ns |  1.00 |    0.06 |      - |     291 B |         - |          NA |
| AsyncLazy         | NoToken    |  0.9800 ns | 0.0106 ns | 0.0099 ns |  0.97 |    0.04 |      - |     854 B |         - |          NA |
| Nito              | NoToken    | 18.6320 ns | 0.0452 ns | 0.0422 ns | 18.52 |    0.74 |      - |     459 B |         - |          NA |
| VsThreading       | NoToken    | 12.6307 ns | 0.0468 ns | 0.0438 ns | 12.55 |    0.50 | 0.0005 |   1,035 B |      40 B |          NA |
|                   |            |            |           |           |       |         |        |           |           |             |
| LazyOfTask_Token  | Token      |  1.6479 ns | 0.0197 ns | 0.0184 ns |  1.00 |    0.02 |      - |     428 B |         - |          NA |
| AsyncLazy_Token   | Token      |  0.9165 ns | 0.0177 ns | 0.0166 ns |  0.56 |    0.01 |      - |     915 B |         - |          NA |
| Nito_Token        | Token      | 18.6253 ns | 0.0530 ns | 0.0496 ns | 11.30 |    0.13 |      - |     684 B |         - |          NA |
| VsThreading_Token | Token      | 12.6114 ns | 0.0572 ns | 0.0535 ns |  7.65 |    0.09 | 0.0005 |   1,065 B |      40 B |          NA |
