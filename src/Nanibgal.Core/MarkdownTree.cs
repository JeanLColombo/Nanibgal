namespace Nanibgal.Core;

/// <summary>
/// Represents a markdown tree.
/// </summary>
public sealed class MarkdownTree
{
    /// <summary>
    /// List of Nodes that make up the tree.
    /// </summary>
    public IReadOnlyList<IMarkdownNode> Nodes { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MarkdownTree"/> class with the specified nodes.
    /// </summary>
    /// <param name="nodes">A list of nodes that make up the tree.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="nodes"/> parameter is null.</exception>
    public MarkdownTree(IReadOnlyList<IMarkdownNode> nodes)
    {
        ArgumentNullException.ThrowIfNull(nodes, nameof(nodes));
        Nodes = nodes.ToArray();
    }
}
