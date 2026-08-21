using System.Runtime.CompilerServices;
namespace Nanibgal.Core.Tests;

public class TestBlockRenderer
{
    [Fact]
    public void Constructor_ShouldRejectNullParser()
    {
        Assert.Throws<ArgumentNullException>(() => new BlockRenderer(null!));
    }

    public static TheoryData<int, string> SampleStringData => new TheoryData<int, string>
    {
        {0, string.Empty },
        {1, "Hello Nanibgal" },
        {2, "# Heading 1\n\nHello Nanibgal" },
        {3, "# Heading 1\n\n## Heading 2\n\nHello Nanibgal" },
        {4, "# Heading 1\n\n## Heading 2\n\n### Heading 3\n\nHello Nanibgal" }
    };

    [Theory]
    [MemberData(nameof(SampleStringData))]
    public void TotalBlocks_ShouldMatchExpected(int expectedCount, string markdown)
    {
        var renderer = new BlockRenderer(markdown);
        Assert.Equal(expectedCount, renderer.TotalBlocks);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(100)]
    public void RenderBlock_ShouldThrowArgumentOutOfRangeException(int index)
    {
        var renderer = new BlockRenderer("# Heading 1\n\nHello Nanibgal");
        Assert.Throws<ArgumentOutOfRangeException>(() => renderer.RenderBlock(index));
    }

    [Theory]
    [InlineData("test0001", 19)]
    public void RenderBlocks_ShouldMatchExpected(string testFolder, int expectedCount)
    {
        var testDataPath = Path.Combine(GetDataPath(), testFolder);
        var markdownFilePath = Path.Combine(testDataPath, "Input.md");
        var renderer = new BlockRenderer(File.ReadAllText(markdownFilePath));

        for (int i = 0; i < expectedCount; i++)
        {
            var expectedFilePath = Path.Combine(testDataPath, $"RenderedBlock{i:D2}.xml");
            var expectedContent = File.ReadAllText(expectedFilePath);

            var actualContent = renderer.RenderBlock(i);

            Assert.Equal(expectedContent, actualContent, ignoreLineEndingDifferences: true);
        }
    }

    static string GetDataPath([CallerFilePath] string sourceFilePath = "")
    {
        return Path.Combine(Path.GetDirectoryName(sourceFilePath)!, "data");
    }
}