using System.Reflection;

namespace App2d.Tests;

internal static class TestAssetPath
{
    internal static string App2dRoot { get; } = typeof(TestAssetPath).Assembly
        .GetCustomAttributes<AssemblyMetadataAttribute>().Single(a => a.Key == "App2dRoot").Value!;
    public static string Root { get; } = Path.Combine(App2dRoot, "Assets", "Runtime");
    public static string StaticRoot { get; } = Path.Combine(App2dRoot, "Assets", "Static");
    public static string AuthoredRoot { get; } = Path.Combine(App2dRoot, "Assets", "Characters", "authored");
}
