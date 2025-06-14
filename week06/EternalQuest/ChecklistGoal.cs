public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine(IsComplete()
            ? $"Goal complete! +{_points} +{_bonus} bonus points!"
            : $"Progress made! +{_points} points.");
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus() =>
        $"[{(IsComplete() ? "X" : " ")}] {_shortName} -- Completed {_currentCount}/{_targetCount} times";

    public override string GetStringRepresentation() =>
        $"Checklist|{_shortName}|{_description}|{_points}|{_bonus}|{_targetCount}|{_currentCount}";

    public int GetReward()
    {
        return _points + _bonus;
    }
}