public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You completed the goal {_shortName}! You earned {_points} points.");
    }

    public override bool isComplete()
    {
        return false; 
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}|False";
    }
}