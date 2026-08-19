namespace Nanibgal.Core.Tests;

public class TestHeadingBlock
{
    [Fact]
    public void Constructor_ShouldRejectNullText()
    {
        Assert.Throws<ArgumentNullException>(() => new HeadingBlock(1, null!));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(7)]
    public void Constructor_ShouldRejectInvalidLevel(int level)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new HeadingBlock(level, "Heading"));
    }

    [Fact]
    public void Constructor_ShouldSetLevelAndText()
    {
        var expected_level = 2;
        var expected_text = "Hello Nanibgal";

        var headingBlock = new HeadingBlock(expected_level, expected_text);

        Assert.Equal(expected_level, headingBlock.Level);
        Assert.Equal(expected_text, headingBlock.Text);
    }
}