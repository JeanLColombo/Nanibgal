namespace Nanibgal.Core.Tests;

public class TestMarkdownTree
{
    [Fact]
    public void Constructor_ShouldPreserveBlocks()
    {
        var expected = new [] { new TestMarkdownBlock() };

        var document = new MarkdownTree(expected);

        Assert.Equal(expected, document.Nodes);
    }

    [Fact]
    public void Constructor_ShouldRejectNullSource()
    {
        Assert.Throws<ArgumentNullException>(() => new MarkdownTree(null!));
    }

    [Fact]
    public void Constructor_ShouldCopySource()
    {
        var blocks = new List<IMarkdownNode> { new TestMarkdownBlock() };

        var document = new MarkdownTree(blocks);

        blocks.Clear();

        Assert.NotSame(blocks, document.Nodes);
        Assert.Single(document.Nodes);
    }

    private sealed class TestMarkdownBlock : IMarkdownNode
    {
    }
}
