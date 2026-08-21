using Markdig;
namespace Nanibgal.Core;

/// <summary>
/// Represents a renderer for Markdown content.
/// </summary>
public sealed class BlockRenderer
{
    private readonly Markdig.Syntax.MarkdownDocument _document;

    public int TotalBlocks => _document.Count;

    /// <summary>
    /// Initializes a new instance of the <see cref="BlockRenderer"/> class with the specified source string.
    /// </summary>
    /// <param name="source">The source string to render.</param>
    public BlockRenderer(string source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        var pipeline = new MarkdownPipelineBuilder().Build();
        _document = Markdown.Parse(source, pipeline);
    }

    /// <summary>
    /// Renders the block at the specified index.
    /// </summary>
    /// <param name="index">The index of the block to render.</param>
    /// <returns>The rendered block as a string.</returns>
    public string RenderBlock(int index)
    {
        if (index < 0 || index >= _document.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }

        var block = _document[index];
        var writer = new StringWriter();
        var renderer = new Markdig.Renderers.HtmlRenderer(writer);
        renderer.Render(block);
        writer.Flush();
        return writer.ToString();
    }
}