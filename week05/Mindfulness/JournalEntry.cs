public class JournalEntry
{
    public DateTime Timestamp { get; }
    public string Content { get; }

    public JournalEntry(string content)
    {
        Timestamp = DateTime.Now;
        Content = content;
    }

    public override string ToString()
    {
        return $"[{Timestamp}] {Content}";
    }
}