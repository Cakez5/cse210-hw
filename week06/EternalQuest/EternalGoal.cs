public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Good habit recorded! +{_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[ ] {_shortName} (eternal)";

    public override string GetStringRepresentation() => $"Eternal|{_shortName}|{_description}|{_points}";
}