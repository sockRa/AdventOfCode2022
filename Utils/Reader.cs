namespace Utils;

public static class Reader
{
    public static IEnumerable<string> ReadFile(string filename)
    {
        const string basePath = @"F:\Projekt\AdventOfCode2022\Input";
        return File.ReadAllLines($@"{basePath}\{filename}.txt");
    }
}