```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.7462/25H2/2025Update/HudsonValley2)
Intel Core Ultra 9 185H 2.50GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.101
  [Host]     : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3


```
| Method          | Sql                  | Mean     | Error   | StdDev  | Allocated |
|---------------- |--------------------- |---------:|--------:|--------:|----------:|
| **GetSanitizedSql** | **CREAT(...)s(Id) [56]** | **257.1 ns** | **3.11 ns** | **2.76 ns** |     **208 B** |
| **GetSanitizedSql** | **DELET(...) = 42 [32]** | **163.2 ns** | **1.97 ns** | **1.64 ns** |     **128 B** |
| **GetSanitizedSql** | **INSER(...)3e-5) [76]** | **319.9 ns** | **2.82 ns** | **2.36 ns** |     **192 B** |
| **GetSanitizedSql** | **SELEC(...)ls od [39]** | **208.6 ns** | **3.63 ns** | **9.30 ns** |     **184 B** |
| **GetSanitizedSql** | **SELE(...)tory [111]**  | **342.7 ns** | **6.09 ns** | **5.40 ns** |     **424 B** |
| **GetSanitizedSql** | **SELEC(...)table [69]** | **147.8 ns** | **1.78 ns** | **1.66 ns** |     **128 B** |
| **GetSanitizedSql** | **SELEC(...) c.Id [74]** | **313.2 ns** | **5.11 ns** | **4.78 ns** |     **248 B** |
| **GetSanitizedSql** | **SELE(...)_id) [101]**  | **384.9 ns** | **6.34 ns** | **5.62 ns** |     **312 B** |
| **GetSanitizedSql** | **UPDAT(...) = 42 [44]** | **203.9 ns** | **2.85 ns** | **2.67 ns** |     **144 B** |
