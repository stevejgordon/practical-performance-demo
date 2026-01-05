```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Intel Core Ultra 9 185H 2.50GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method          | Sql                  | Mean     | Error    | StdDev   | Allocated |
|---------------- |--------------------- |---------:|---------:|---------:|----------:|
| **GetSanitizedSql** | **CREAT(...)s(Id) [56]** | **379.1 ns** |  **7.58 ns** |  **8.73 ns** |     **216 B** |
| **GetSanitizedSql** | **DELET(...) = 42 [32]** | **261.3 ns** |  **2.91 ns** |  **2.58 ns** |     **216 B** |
| **GetSanitizedSql** | **INSER(...)3e-5) [76]** | **529.0 ns** |  **9.71 ns** |  **9.08 ns** |     **272 B** |
| **GetSanitizedSql** | **SELEC(...)ls od [39]** | **315.2 ns** |  **4.85 ns** |  **4.53 ns** |     **312 B** |
| **GetSanitizedSql** | **SELE(...)tory [111]**  | **580.7 ns** |  **4.76 ns** |  **4.22 ns** |     **656 B** |
| **GetSanitizedSql** | **SELEC(...)table [69]** | **249.0 ns** |  **4.29 ns** |  **4.02 ns** |     **200 B** |
| **GetSanitizedSql** | **SELEC(...) c.Id [74]** | **530.5 ns** |  **8.16 ns** |  **7.24 ns** |     **368 B** |
| **GetSanitizedSql** | **SELE(...)_id) [101]**  | **745.5 ns** | **14.82 ns** | **20.29 ns** |     **432 B** |
| **GetSanitizedSql** | **UPDAT(...) = 42 [44]** | **332.7 ns** |  **6.52 ns** |  **9.76 ns** |     **184 B** |
