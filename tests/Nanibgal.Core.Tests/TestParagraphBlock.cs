namespace Nanibgal.Core.Tests;

public class TestParagraphBlock
{
    [Fact]
    public void Constructor_ShouldPreserveText()
    {
        var expectedText = "Hello Nanibgal";

        var paragraphBlock = new ParagraphBlock(expectedText);

        Assert.Equal(expectedText, paragraphBlock.Text);
    }

    [Fact]
    public void Constructor_ShouldRejectNullText()
    {
        Assert.Throws<ArgumentNullException>(() => new ParagraphBlock(null!));
    }

    [Fact]
    public void Constructor_ShouldAllowEmptyText()
    {
        var paragraphBlock = new ParagraphBlock(string.Empty);

        Assert.Equal(string.Empty, paragraphBlock.Text);
    }
}