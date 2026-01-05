```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Intel Core Ultra 9 185H 2.50GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method          | Sql                  | Mean     | Error    | StdDev   | Allocated |
|---------------- |--------------------- |---------:|---------:|---------:|----------:|
| **GetSanitizedSql** | **CREAT(...)s(Id) [56]** | **345.6 ns** |  **2.92 ns** |  **2.44 ns** |     **216 B** |
| **GetSanitizedSql** | **DELET(...) = 42 [32]** | **249.3 ns** |  **5.00 ns** |  **6.14 ns** |     **216 B** |
| **GetSanitizedSql** | **INSER(...)3e-5) [76]** | **495.8 ns** |  **9.89 ns** | **12.15 ns** |     **272 B** |
| **GetSanitizedSql** | **SELEC(...)ls od [39]** | **290.3 ns** |  **5.67 ns** |  **6.75 ns** |     **312 B** |
| **GetSanitizedSql** | **SELE(...)tory [111]**  | **535.2 ns** |  **9.25 ns** |  **7.73 ns** |     **656 B** |
| **GetSanitizedSql** | **SELEC(...)table [69]** | **214.8 ns** |  **1.56 ns** |  **1.39 ns** |     **200 B** |
| **GetSanitizedSql** | **SELEC(...) c.Id [74]** | **499.0 ns** |  **7.22 ns** |  **6.03 ns** |     **368 B** |
| **GetSanitizedSql** | **SELE(...)_id) [101]**  | **659.9 ns** | **12.54 ns** | **12.32 ns** |     **432 B** |
| **GetSanitizedSql** | **UPDAT(...) = 42 [44]** | **305.7 ns** |  **5.97 ns** |  **6.13 ns** |     **184 B** |
