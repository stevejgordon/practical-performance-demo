```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Intel Core Ultra 9 185H 2.50GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method          | Sql                  | Mean     | Error    | StdDev   | Allocated |
|---------------- |--------------------- |---------:|---------:|---------:|----------:|
| **GetSanitizedSql** | **CREAT(...)s(Id) [56]** | **384.2 ns** |  **6.83 ns** |  **9.12 ns** |     **584 B** |
| **GetSanitizedSql** | **DELET(...) = 42 [32]** | **262.3 ns** |  **4.79 ns** |  **4.48 ns** |     **488 B** |
| **GetSanitizedSql** | **INSER(...)3e-5) [76]** | **553.8 ns** |  **4.72 ns** |  **3.94 ns** |     **720 B** |
| **GetSanitizedSql** | **SELEC(...)ls od [39]** | **311.3 ns** |  **5.71 ns** |  **5.35 ns** |     **616 B** |
| **GetSanitizedSql** | **SELE(...)tory [111]**  | **605.7 ns** | **12.10 ns** | **12.95 ns** |    **1248 B** |
| **GetSanitizedSql** | **SELEC(...)table [69]** | **265.7 ns** |  **5.21 ns** |  **5.57 ns** |     **632 B** |
| **GetSanitizedSql** | **SELEC(...) c.Id [74]** | **545.9 ns** |  **8.81 ns** |  **8.24 ns** |     **816 B** |
| **GetSanitizedSql** | **SELE(...)_id) [101]**  | **746.6 ns** | **14.67 ns** | **18.02 ns** |     **992 B** |
| **GetSanitizedSql** | **UPDAT(...) = 42 [44]** | **332.6 ns** |  **6.30 ns** |  **5.89 ns** |     **504 B** |
