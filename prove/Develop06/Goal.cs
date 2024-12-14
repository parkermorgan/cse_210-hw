public abstract class Goal 
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _isComplete = false;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool isComplete();
    
    public string getName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName}: {_description} ({_points} points)";
    }

    public abstract string GetStringRepresentation();
}