using System.Diagnostics.CodeAnalysis;

namespace Nanibgal.Core.Tests;

public class TestMarkdownDocument
{
    [Fact]
    public void Constructor_ShouldPreserveSource()
    {
        var expected = "# Hello Nanibgal";

        var document = new MarkdownDocument("# Hello Nanibgal");

        Assert.Equal(expected, document.Source);
    }

    [Fact]
    public void Constructor_ShouldRejectNullSource()
    {
        Assert.Throws<ArgumentNullException>(() => new MarkdownDocument(null!));
    }
}
