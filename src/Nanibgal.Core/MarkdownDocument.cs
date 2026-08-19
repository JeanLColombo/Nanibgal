namespace Nanibgal.Core;

/// <summary>
/// Represents a markdown document.
/// </summary>
public sealed class MarkdownDocument
{
    /// <summary>
    /// List of blocks that make up the document.
    /// </summary>
    public IReadOnlyList<IMarkdownBlock> Blocks { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownDocument"/> class with the specified blocks.
    /// </summary>
    /// <param name="blocks">A list of blocks that make up the document.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="blocks"/> parameter is null.</exception>
    public MarkdownDocument(IReadOnlyList<IMarkdownBlock> blocks)
    {
        ArgumentNullException.ThrowIfNull(blocks, nameof(blocks));
        Blocks = blocks.ToArray();
    }
}
