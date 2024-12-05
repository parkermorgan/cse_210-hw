
public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public string GetSummary(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
        return $"{name} - {topic}";
    }
}