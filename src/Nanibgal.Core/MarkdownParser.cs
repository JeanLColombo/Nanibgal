namespace Nanibgal.Core;

/// <summary>
/// Represents a markdown parser.
/// </summary>
public sealed class MarkdownParser : IMarkdownParser
{
    /// <summary>
    /// Parses the specified source string into a <see cref="MarkdownTree"/>.
    /// </summary>
    /// <param name="source">The source string to parse.</param>
    /// <returns>The parsed <see cref="MarkdownTree"/>.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the <paramref name="source"/> parameter is null.</exception>
    public MarkdownTree Parse(string source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        throw new NotImplementedException();
    }
}