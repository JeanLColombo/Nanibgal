using Markdig;
namespace Nanibgal.Core;

/// <summary>
/// Represents a renderer for Markdown content.
/// </summary>
public sealed class BlockRenderer
{
    private static readonly MarkdownPipeline _pipeline = new MarkdownPipelineBuilder().Build();
    private Markdig.Syntax.MarkdownDocument _document;
    public int TotalBlocks => _document.Count;

    /// <summary>
    /// Initializes a new instance of the <see cref="BlockRenderer"/> class with the specified source string.
    /// </summary>
    /// <param name="source">The source string to render.</param>
    public BlockRenderer(string source = "")
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        _document = Markdown.Parse(source, _pipeline);
    }

    /// <summary>
    /// Updates the source string and re-parses the Markdown content.
    /// </summary>
    /// <param name="source">The new source string to render.</param>
    public void UpdateSource(string source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        _document = Markdown.Parse(source, _pipeline);
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