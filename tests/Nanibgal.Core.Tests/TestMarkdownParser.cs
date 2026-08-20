namespace Nanibgal.Core.Tests;

public class TestMarkdownParser
{
    public static TheoryData<string> MarkdownSources => new()
    {
        "# Heading 1\n\nThis is a paragraph.",
        """
        # Heading 1

        This is a paragraph.

        ## Heading 2

        Another paragraph.
        """
    };
/*
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

    [Theory]
    [InlineData("# Heading 1", 1, "Heading 1")]
    [InlineData("## Heading 2", 2, "Heading 2")]
    [InlineData("#", 1, "")]
    [InlineData("### ", 3, "")]
    [InlineData("####  ", 4, " ")]
    [InlineData("   ##### Heading 5   ", 5, "Heading 5   ")]
    public void Parse_HeadingBlock(string source, int expectedLevel, string expectedText)
    {
        var parser = new MarkdownParser();
        var document = parser.Parse(source);

        Assert.Single(document.Blocks);

        var headingBlock = Assert.IsType<HeadingBlock>(document.Blocks[0]);

        Assert.Equal(expectedLevel, headingBlock.Level);
        Assert.Equal(expectedText, headingBlock.Text);
    }

    [Theory]
    [InlineData("This is a paragraph.", "This is a paragraph.")]
    [InlineData("   Leading and trailing spaces   ", "   Leading and trailing spaces   ")]
    [InlineData("", "")]
    public void Parse_ParagraphBlock(string source, string expectedText)
    {
        var parser = new MarkdownParser();
        var document = parser.Parse(source);

        Assert.Single(document.Blocks);

        var paragraphBlock = Assert.IsType<ParagraphBlock>(document.Blocks[0]);

        Assert.Equal(expectedText, paragraphBlock.Text);
    }

    public static TheoryData<string, IMarkdownNode[]> MultipleBlocksData
    {
        get
        {
            var data = new TheoryData<string, IMarkdownNode[]>();

            data.Add("# Heading 1\n\nThis is a paragraph.", new IMarkdownNode[] {
                new HeadingBlock(1, "Heading 1"),
                new ParagraphBlock("This is a paragraph.")
            });

            data.Add("## Heading 2\n\nThis is another paragraph.", new IMarkdownNode[] {
                new HeadingBlock(2, "Heading 2"),
                new ParagraphBlock("This is another paragraph.")
            });

            data.Add("Paragraph 1\n\nParagraph 2", new IMarkdownNode[] {
                new ParagraphBlock("Paragraph 1"),
                new ParagraphBlock("Paragraph 2")
            });

            data.Add("# Heading 1\n\n## Heading 2\n\n### Heading 3", new IMarkdownNode[] {
                new HeadingBlock(1, "Heading 1"),
                new HeadingBlock(2, "Heading 2"),
                new HeadingBlock(3, "Heading 3")
            });

            data.Add("Paragraph with\nmultiple\nlines", new IMarkdownNode[] {
                new ParagraphBlock("Paragraph with\nmultiple\nlines")
            });
            data.Add("this\nis something\n# new\nI tell you", new IMarkdownNode[] {
                new ParagraphBlock("this\nis something"),
                new HeadingBlock(1, "new"),
                new ParagraphBlock("I tell you")
            });

            return data;
        }
    }

    [Theory]
    [MemberData(nameof(MultipleBlocksData))]
    public void Parse_ShouldReturnExpectedBlocks(string source, IMarkdownNode[] expectedBlocks)
    {
            var parser = new MarkdownParser();

        var document = parser.Parse(source);

        Assert.Equal(expectedBlocks.Length, document.Blocks.Count);

        for (var i = 0; i < expectedBlocks.Length; i++)
        {
            Assert.Equal(expectedBlocks[i].GetType(), document.Blocks[i].GetType());
            if (expectedBlocks[i].GetType() == typeof(HeadingBlock))
            {
                var expectedHeading = (HeadingBlock)expectedBlocks[i];
                var actualHeading = (HeadingBlock)document.Blocks[i];
                Assert.Equal(expectedHeading.Level, actualHeading.Level);
                Assert.Equal(expectedHeading.Text, actualHeading.Text);
            }
            else if (expectedBlocks[i].GetType() == typeof(ParagraphBlock))
            {
                var expectedParagraph = (ParagraphBlock)expectedBlocks[i];
                var actualParagraph = (ParagraphBlock)document.Blocks[i];
                Assert.Equal(expectedParagraph.Text, actualParagraph.Text);
            }
        }
    }
*/
}