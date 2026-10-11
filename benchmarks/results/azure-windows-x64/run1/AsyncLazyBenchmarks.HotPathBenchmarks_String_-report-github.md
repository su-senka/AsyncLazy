```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26100.33438/24H2/2024Update/HudsonValley) (Hyper-V)
INTEL XEON PLATINUM 8573C 2.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4


```
| Method            | Categories | Mean       | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |-----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.0228 ns | 0.0280 ns | 0.0262 ns |  1.00 |    0.03 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  0.9896 ns | 0.0201 ns | 0.0188 ns |  0.97 |    0.03 |      - |         - |          NA |
| Nito              | NoToken    | 18.5985 ns | 0.0348 ns | 0.0309 ns | 18.20 |    0.44 |      - |         - |          NA |
| VsThreading       | NoToken    | 13.3801 ns | 0.0308 ns | 0.0288 ns | 13.09 |    0.32 | 0.0005 |      40 B |          NA |
|                   |            |            |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.6660 ns | 0.0287 ns | 0.0269 ns |  1.00 |    0.02 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.2946 ns | 0.0303 ns | 0.0283 ns |  0.78 |    0.02 |      - |         - |          NA |
| Nito_Token        | Token      | 18.6120 ns | 0.0479 ns | 0.0448 ns | 11.17 |    0.18 |      - |         - |          NA |
| VsThreading_Token | Token      | 13.3429 ns | 0.0366 ns | 0.0324 ns |  8.01 |    0.13 | 0.0005 |      40 B |          NA |
