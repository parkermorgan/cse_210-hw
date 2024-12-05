public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment() : base()
    {
        
    }

    public MathAssignment(string name, string topic, string section, string problems) : base()
    {
        _studentName = name;
        _topic = topic;
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList(string section, string problems)
    {
        _textbookSection = section;
        _problems = problems;

        return $"Section {section} Problems {problems}";
    }
}