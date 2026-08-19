namespace Nanibgal.Core;

/// <summary>
/// Represents a markdown parser.
/// </summary>
public interface IMarkdownParser
{
    /// <summary>
    /// Parses the specified source string into a <see cref="MarkdownDocument"/>.
    /// </summary>
    /// <param name="source">The source string to parse.</param>
    /// <returns>The parsed <see cref="MarkdownDocument"/>.</returns>
    MarkdownDocument Parse(string source);
}