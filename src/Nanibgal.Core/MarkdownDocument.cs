namespace Nanibgal.Core;

public sealed class MarkdownDocument
{
    public string Source { get; }

    public MarkdownDocument(string source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));
        Source = source;
    }
}
