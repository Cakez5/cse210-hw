public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        : base("Breathing", "Focus on your breathing with calm rhythm.", duration) { }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithCountdown(3);
            Console.WriteLine("Breathe out...");
            PauseWithCountdown(3);
        }
        DisplayEndingMessage();
    }
}