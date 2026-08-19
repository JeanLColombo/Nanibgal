namespace Nanibgal.Core.Tests;

public class TestMarkdownParser
{
    [Fact]
    public void Parse_ShouldThrowNotImplementedException()
    {
        var parser = new MarkdownParser();

        Assert.Throws<NotImplementedException>(() => parser.Parse("Sample markdown content"));
    }

    [Fact]
    public void Parse_ShouldRejectNullSource()
    {
        var parser = new MarkdownParser();

        Assert.Throws<ArgumentNullException>(() => parser.Parse(null!));
    }
}