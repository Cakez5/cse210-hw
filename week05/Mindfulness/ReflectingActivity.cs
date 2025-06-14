public class ReflectingActivity : Activity
{
    private string[] _prompts = { "Think of a time you felt peace.", "Remember when you helped someone in need." };
    private string[] _questions = { "Why was this experience meaningful?", "What did you learn about yourself?" };

    public ReflectingActivity(int duration)
        : base("Reflecting", "Think deeply about a meaningful personal experience.", duration) { }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prompt: " + GetRandomPrompt());
        PauseWithSpinner(2);

        foreach (var question in _questions)
        {
            Console.WriteLine("\n" + question);
            PauseWithCountdown(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Length)];
    }
}