using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using JetBrains.Profiler.Api;
using SqlProcessorDemo;

const string memoryProfilingMode = "memory-profiling";
const string vsMemoryProfilingMode = "vs-memory-profiling";
const string cpuProfilingMode = "trace-cpu";
const string defaultMode = "benchmark";

var mode = args.Length > 0 ? args[0] switch
{
    "dotmemory" => memoryProfilingMode,
    "dottrace" => cpuProfilingMode,
    "vsmemory" => vsMemoryProfilingMode,
    _ => defaultMode
} : defaultMode;

Console.WriteLine("Selected mode: {0}", mode);

const string statement = "SELECT * FROM Orders o, OrderDetails od WHERE quantity > 25";

var statements = new string[50];
for (var i = 0; i < 50; i++)
{
    statements[i] = "SELECT * FROM Orders o, OrderDetails od WHERE quantity > " + i;
}

switch (mode)
{
    case memoryProfilingMode:
        PrepareForProfiling(1000);
        MemoryProfiler.CollectAllocations(true);
        MemoryProfiler.GetSnapshot("Before");
        SqlProcessor.GetSanitizedSql("SELECT name FROM Customers");
        MemoryProfiler.GetSnapshot("After");
        break;

    case vsMemoryProfilingMode:
        PrepareForProfiling(0);

        Span<long> data = stackalloc long[4];

        Console.WriteLine("Take before snapshot");
        Console.ReadKey();

        GC.GetTotalAllocatedBytes(true);
        GC.GetAllocatedBytesForCurrentThread();

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        data[0] = GC.GetTotalAllocatedBytes(true);
        data[1] = GC.GetAllocatedBytesForCurrentThread();

        SqlProcessor.GetSanitizedSql("SELECT * FROM Orders d, OrderDetails ox");

        data[2] = GC.GetTotalAllocatedBytes(true);
        data[3] = GC.GetAllocatedBytesForCurrentThread();

        Console.WriteLine("Take after snapshot");
        Console.ReadKey();

        Console.WriteLine("Total allocated bytes: {0}", data[2] - data[0]);
        Console.WriteLine("Total allocated bytes for current thread: {0}", data[3] - data[1]);

        Console.ReadKey();

        break;

    case cpuProfilingMode:
        var iterations = args.Length > 1 ? int.Parse(args[1]) : 1;
        Console.WriteLine("Running CPU profiling for {0} iterations...", iterations);

        PrepareForProfiling();
        MeasureProfiler.StartCollectingData();

        for (var i = 0; i < iterations; i++)
        {
            SqlProcessor.GetSanitizedSql(statement);
        }

        MeasureProfiler.SaveData();
        break;

    default:
        var config = ManualConfig.Create(DefaultConfig.Instance)
            .WithArtifactsPath("BenchmarkResults")
            .HideColumns(Column.Error, Column.StdDev, Column.Method, Column.Median);
        BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, config);
        break;
}

static void PrepareForProfiling(int cacheCapacity = 0)
{
    SqlProcessor.CacheCapacity = cacheCapacity;

    var statements = new[]
    {
        "SELECT * FROM Orders o, OrderDetails od",
        "SELECT id, name, dob FROM Users WHERE age > 5000",
        "INSERT INTO Logs (message) VALUES ('test')",
        "UPDATE Products SET price = 100 WHERE id = 1",
        "DELETE FROM Cache WHERE expires < NOW()"
    };

    // JIT warmup - ensure all code paths are compiled and promote methods to optimized code
    for (int i = 0; i < 100; i++)
    {
        foreach (var statement in statements)
        {
            SqlProcessor.GetSanitizedSql(statement);
        }
    }

    // Force GC to establish clean baseline
    GC.Collect();
    GC.WaitForPendingFinalizers();
    GC.Collect();

    // Small delay to let system stabilize
    Thread.Sleep(100);
}