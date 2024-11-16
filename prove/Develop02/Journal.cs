public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    private PromptGenerator _promptGenerator;

    public Journal(PromptGenerator promptGenerator)
    {
        _promptGenerator = promptGenerator;
    }

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.GetDate();
        newEntry.SetPrompt(_promptGenerator);
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {

    }

    public void SaveToFile(string file)
    {

    }public void LoadFromFile(string file)
    {

    }
}