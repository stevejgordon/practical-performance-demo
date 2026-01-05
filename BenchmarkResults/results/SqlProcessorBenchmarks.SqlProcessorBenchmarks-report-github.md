```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Intel Core Ultra 9 185H 2.50GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method          | Sql                  | Mean     | Error    | StdDev   | Allocated |
|---------------- |--------------------- |---------:|---------:|---------:|----------:|
| **GetSanitizedSql** | **CREAT(...)s(Id) [56]** | **404.7 ns** |  **5.84 ns** |  **5.46 ns** |     **664 B** |
| **GetSanitizedSql** | **DELET(...) = 42 [32]** | **284.2 ns** |  **4.15 ns** |  **3.89 ns** |     **528 B** |
| **GetSanitizedSql** | **INSER(...)3e-5) [76]** | **556.4 ns** |  **6.16 ns** |  **5.76 ns** |     **720 B** |
| **GetSanitizedSql** | **SELEC(...)ls od [39]** | **360.0 ns** |  **6.07 ns** |  **8.51 ns** |     **864 B** |
| **GetSanitizedSql** | **SELE(...)tory [111]**  | **728.8 ns** | **14.52 ns** | **15.54 ns** |    **1800 B** |
| **GetSanitizedSql** | **SELEC(...)table [69]** | **277.2 ns** |  **5.06 ns** |  **4.48 ns** |     **512 B** |
| **GetSanitizedSql** | **SELEC(...) c.Id [74]** | **622.0 ns** | **11.76 ns** | **11.00 ns** |    **1120 B** |
| **GetSanitizedSql** | **SELE(...)_id) [101]**  | **825.0 ns** |  **8.36 ns** |  **7.82 ns** |    **1184 B** |
| **GetSanitizedSql** | **UPDAT(...) = 42 [44]** | **368.9 ns** |  **6.99 ns** |  **7.47 ns** |     **632 B** |
