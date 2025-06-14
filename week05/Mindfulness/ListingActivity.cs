public class ListingActivity : Activity
{
    private string[] _prompts = { "List things you're grateful for:", "List your achievements today:" };

    public ListingActivity(int duration)
        : base("Listing", "Encourage yourself by listing positive thoughts.", duration) { }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
                items.Add(entry);
        }

        Console.WriteLine($"\nYou listed {items.Count} items.");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Length)];
    }
}