//PREFACE: ChatGPT was used in creating second GetDetailsString().
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

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool value)
    {
        _isComplete = value;
    }

    public string GetDetailsString()
    {
        string _checkbox = _isComplete ? "[X]" : "[ ]";

        if (this is ChecklistGoal checklistGoal)
        {
            _checkbox = $"{_checkbox} (Completed {checklistGoal.GetTimesCompleted()}/{checklistGoal.GetTargetCount()} times)";
        }
        return $"{_checkbox} {_shortName}: {_description} ({_points} points)";
    }

    public abstract string GetStringRepresentation();
}