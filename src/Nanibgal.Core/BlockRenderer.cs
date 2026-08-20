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
}