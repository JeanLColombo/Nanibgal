namespace Nanibgal.Core;

/// <summary>
/// Represents a markdown document.
/// </summary>
public sealed class MarkdownDocument
{
    /// <summary>
    /// List of blocks that make up the document.
    /// </summary>
    public IReadOnlyList<IMarkdownNode> Nodes { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownDocument"/> class with the specified nodes.
    /// </summary>
    /// <param name="nodes">A list of nodes that make up the document.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="nodes"/> parameter is null.</exception>
    public MarkdownDocument(IReadOnlyList<IMarkdownNode> nodes)
    {
        ArgumentNullException.ThrowIfNull(nodes, nameof(nodes));
        Nodes = nodes.ToArray();
    }
}
