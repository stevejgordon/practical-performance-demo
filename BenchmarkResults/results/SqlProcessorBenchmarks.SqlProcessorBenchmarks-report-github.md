```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Intel Core Ultra 9 185H 2.50GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method          | Sql                  | Mean     | Error    | StdDev   | Allocated |
|---------------- |--------------------- |---------:|---------:|---------:|----------:|
| **GetSanitizedSql** | **CREAT(...)s(Id) [56]** | **353.1 ns** |  **6.21 ns** |  **5.81 ns** |     **216 B** |
| **GetSanitizedSql** | **DELET(...) = 42 [32]** | **235.8 ns** |  **2.74 ns** |  **2.43 ns** |     **176 B** |
| **GetSanitizedSql** | **INSER(...)3e-5) [76]** | **477.1 ns** |  **9.06 ns** |  **8.47 ns** |     **232 B** |
| **GetSanitizedSql** | **SELEC(...)ls od [39]** | **275.3 ns** |  **3.31 ns** |  **3.09 ns** |     **224 B** |
| **GetSanitizedSql** | **SELE(...)tory [111]**  | **517.3 ns** |  **5.14 ns** |  **4.29 ns** |     **464 B** |
| **GetSanitizedSql** | **SELEC(...)table [69]** | **211.8 ns** |  **4.17 ns** |  **3.90 ns** |     **168 B** |
| **GetSanitizedSql** | **SELEC(...) c.Id [74]** | **482.3 ns** |  **3.44 ns** |  **3.05 ns** |     **288 B** |
| **GetSanitizedSql** | **SELE(...)_id) [101]**  | **651.1 ns** | **12.46 ns** | **11.65 ns** |     **352 B** |
| **GetSanitizedSql** | **UPDAT(...) = 42 [44]** | **311.2 ns** |  **6.05 ns** |  **5.66 ns** |     **184 B** |
