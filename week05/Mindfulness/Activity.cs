public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...\n{_description}");
        PauseWithSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nGood job! You've completed {_duration} seconds of {_name}.");
        PauseWithSpinner(3);
    }

    protected void PauseWithSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(200);
            Console.Write("\b");
            index = (index + 1) % spinner.Length;
        }
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}