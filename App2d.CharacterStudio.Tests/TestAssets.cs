namespace App2d.Tests;

internal static class TestAssets
{
    public static string GetPath(params string[] segments) =>
        Path.Combine([TestAssetPath.App2dRoot, "Assets", .. segments]);
}
