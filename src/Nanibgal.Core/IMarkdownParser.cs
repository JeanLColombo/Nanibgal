namespace Nanibgal.Core;

/// <summary>
/// Represents a markdown parser.
/// </summary>
public interface IMarkdownParser
{
    /// <summary>
    /// Parses the specified source string into a <see cref="MarkdownTree"/>.
    /// </summary>
    /// <param name="source">The source string to parse.</param>
    /// <returns>The parsed <see cref="MarkdownTree"/>.</returns>
    MarkdownTree Parse(string source);
}