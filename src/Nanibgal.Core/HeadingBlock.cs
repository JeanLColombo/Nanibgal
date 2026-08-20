namespace Nanibgal.Core;

/// <summary>
/// Represents a heading block in a markdown document.
/// </summary>
public sealed class HeadingBlock : IMarkdownNode
{
    public int Level { get; }
    public string Text { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="HeadingBlock"/> class with the specified level and text.
    /// </summary>
    /// <param name="level">The level of the heading.</param>
    /// <param name="text">The contents of the heading.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the <paramref name="level"/> parameter is less than 1 or greater than 6.</exception>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="text"/> or <paramref name="level"/> parameter is null.</exception>
    public HeadingBlock(int level, string text)
    {
        if (level < 1 || level > 6)
        {
            throw new ArgumentOutOfRangeException(nameof(level), "Heading level must be between 1 and 6.");
        }

        ArgumentNullException.ThrowIfNull(text, nameof(text));

        Level = level;
        Text = text;
    }
}