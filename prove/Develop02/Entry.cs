public class Entry
{
    DateTime theCurrentTime = DateTime.Now;

    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        _date = theCurrentTime.ToShortDateString();
    }

    public void SetPrompt(string prompt)
    {
        _promptText = prompt;
    }

    public void Display()
    {
        Console.WriteLine("Prompt: " + _promptText);
    }
}