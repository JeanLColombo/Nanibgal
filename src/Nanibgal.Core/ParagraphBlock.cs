namespace Nanibgal.Core;

/// <summary>
/// Represents a paragraph block in a markdown document.
/// </summary>
public sealed class ParagraphBlock : IMarkdownNode
{
    public string Text { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ParagraphBlock"/> class with the specified text.
    /// </summary>
    /// <param name="text">The contents of the paragraph.</param>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="text"/> parameter is null.</exception>
    public ParagraphBlock(string text)
    {
        ArgumentNullException.ThrowIfNull(text, nameof(text));
        Text = text;
    }
}