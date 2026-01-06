```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Intel Core Ultra 9 185H 2.50GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method          | Sql                  | Mean     | Error   | StdDev   | Allocated |
|---------------- |--------------------- |---------:|--------:|---------:|----------:|
| **GetSanitizedSql** | **CREAT(...)s(Id) [56]** | **254.8 ns** | **3.34 ns** |  **3.12 ns** |      **72 B** |
| **GetSanitizedSql** | **DELET(...) = 42 [32]** | **167.0 ns** | **2.41 ns** |  **2.13 ns** |     **128 B** |
| **GetSanitizedSql** | **INSER(...)3e-5) [76]** | **319.8 ns** | **3.74 ns** |  **3.31 ns** |     **192 B** |
| **GetSanitizedSql** | **SELEC(...)ls od [39]** | **191.3 ns** | **2.44 ns** |  **2.28 ns** |      **80 B** |
| **GetSanitizedSql** | **SELE(...)tory [111]**  | **356.6 ns** | **5.94 ns** | **14.11 ns** |     **176 B** |
| **GetSanitizedSql** | **SELEC(...)table [69]** | **150.9 ns** | **2.72 ns** |  **2.55 ns** |     **128 B** |
| **GetSanitizedSql** | **SELEC(...) c.Id [74]** | **296.0 ns** | **4.31 ns** |  **3.60 ns** |      **72 B** |
| **GetSanitizedSql** | **SELE(...)_id) [101]**  | **380.1 ns** | **3.20 ns** |  **2.83 ns** |      **88 B** |
| **GetSanitizedSql** | **UPDAT(...) = 42 [44]** | **206.4 ns** | **2.78 ns** |  **2.47 ns** |     **144 B** |
