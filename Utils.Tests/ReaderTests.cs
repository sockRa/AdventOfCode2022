using Xunit;

namespace Utils.Tests;

public class ReaderTests
{
    [Theory]
    [InlineData("Day1_part1")]
    [InlineData("Day1_part2")]
    public void FromInputDirectory_ReturnFilenames(string filename)
    {
        var result = Reader.ReadFile(filename);
        Assert.NotEmpty(result);
    }
}