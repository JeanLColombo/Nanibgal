namespace Nanibgal.Core.Tests;

public class TestBlockRenderer
{
    [Fact]
    public void Constructor_ShouldRejectNullParser()
    {
        Assert.Throws<ArgumentNullException>(() => new BlockRenderer(null!));
    }

    public static TheoryData<int, string> SampleRenderedData => new TheoryData<int, string>
    {
        {0, string.Empty },
        { 1, "Hello Nanibgal" },
        { 2, "# Heading 1\n\nHello Nanibgal" },
        { 3, "# Heading 1\n\n## Heading 2\n\nHello Nanibgal" },
        { 4, "# Heading 1\n\n## Heading 2\n\n### Heading 3\n\nHello Nanibgal" }
    };

    [Theory]
    [MemberData(nameof(SampleRenderedData))]
    public void TotalBlocks_ShouldMatchExpected(int expectedCount, string markdown)
    {
        var renderer = new BlockRenderer(markdown);
        Assert.Equal(expectedCount, renderer.TotalBlocks);
    }
}