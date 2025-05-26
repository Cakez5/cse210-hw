using System;

public class Entry
{
    public DateTime Date { get; }
    public string Prompt { get; }
    public string Content { get; }

    public Entry(string prompt, string content)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Content = content;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Prompt}\n{Content}\n";
    }
}