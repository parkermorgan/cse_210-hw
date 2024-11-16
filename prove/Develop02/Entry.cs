public class Entry
{
    DateTime theCurrentTime = DateTime.Now;

    public string _date;
    public string _promptText;
    public string _entryText;

    public void GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void SetPrompt(PromptGenerator promptGenerator)
    {
        _promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}