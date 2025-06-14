public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Completed! +{_points} points.");
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => $"[{"X",1}] {_shortName}";

    public override string GetStringRepresentation() => $"Simple|{_shortName}|{_description}|{_points}|{_isComplete}";
}