using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

namespace Nanibgal.Core.Tests;

public class TestMarkdownDocument
{
    [Fact]
    public void Constructor_ShouldPreserveBlocks()
    {
        var expected = new [] { new TestMarkdownBlock() };

        var document = new MarkdownDocument(expected);

        Assert.Equal(expected, document.Blocks);
    }

    [Fact]
    public void Constructor_ShouldRejectNullSource()
    {
        Assert.Throws<ArgumentNullException>(() => new MarkdownDocument(null!));
    }

    [Fact]
    public void Constructor_ShouldCopySource()
    {
        var blocks = new List<IMarkdownBlock> { new TestMarkdownBlock() };

        var document = new MarkdownDocument(blocks);

        blocks.Clear();

        Assert.NotSame(blocks, document.Blocks);
        Assert.Single(document.Blocks);
    }

    private sealed class TestMarkdownBlock : IMarkdownBlock
    {
    }
}
