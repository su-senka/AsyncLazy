```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD EPYC 7763 2.45GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 10.0.401
  [Host]     : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3


```
| Method            | Categories | Mean      | Error     | StdDev    | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------------ |----------- |----------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| LazyOfTask        | NoToken    |  1.033 ns | 0.0021 ns | 0.0019 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy         | NoToken    |  1.132 ns | 0.0044 ns | 0.0041 ns |  1.10 |    0.00 |      - |         - |          NA |
| Nito              | NoToken    | 10.669 ns | 0.0089 ns | 0.0084 ns | 10.33 |    0.02 |      - |         - |          NA |
| VsThreading       | NoToken    |  8.471 ns | 0.1883 ns | 0.1669 ns |  8.20 |    0.16 | 0.0024 |      40 B |          NA |
|                   |            |           |           |           |       |         |        |           |             |
| LazyOfTask_Token  | Token      |  1.761 ns | 0.0013 ns | 0.0012 ns |  1.00 |    0.00 |      - |         - |          NA |
| AsyncLazy_Token   | Token      |  1.277 ns | 0.0011 ns | 0.0010 ns |  0.73 |    0.00 |      - |         - |          NA |
| Nito_Token        | Token      | 10.684 ns | 0.0062 ns | 0.0055 ns |  6.07 |    0.00 |      - |         - |          NA |
| VsThreading_Token | Token      |  8.180 ns | 0.1265 ns | 0.1183 ns |  4.64 |    0.07 | 0.0024 |      40 B |          NA |
