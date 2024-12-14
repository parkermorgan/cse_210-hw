//PREFACE: ChatGPT was used for formatting GetStringRepresentation() and determining how to add the extra attributes to RecordEvent.

public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        Console.WriteLine($"You recorded progress for the goal: {_shortName}! You earned {_points} points.");

        if (_timesCompleted == _targetCount)
        {
            Console.WriteLine($"Congratulations! You completed the checklist goal: {_shortName} and earned {_bonusPoints} bonus points!");
            _isComplete = true;
        }
        else if (_timesCompleted > _targetCount)
        {
            Console.WriteLine($"You already completed the goal: {_shortName}. Additional progress will not earn a bonus.");
        }
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_timesCompleted}|{_targetCount}|{_bonusPoints}|{_isComplete}";
    }
}