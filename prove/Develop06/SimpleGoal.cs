//PREFACE: ChatGPT was used to find the best way to format GetStringRepresentation
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"You have completed the goal: {_shortName}!");
        }
        else
        {
            Console.WriteLine("You have already completed this goal.");
        }
    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}