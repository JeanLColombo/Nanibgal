namespace Nanibgal.Core.Tests;

public class TestParagraphBlock
{
    [Fact]
    public void Constructor_ShouldPreserveText()
    {
        var expectedText = "This is a sample paragraph.";

        var paragraphBlock = new ParagraphBlock(expectedText);

        Assert.Equal(expectedText, paragraphBlock.Text);
    }

    [Fact]
    public void Constructor_ShouldRejectNullText()
    {
        Assert.Throws<ArgumentNullException>(() => new ParagraphBlock(null!));
    }
}