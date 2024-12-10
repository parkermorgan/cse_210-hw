public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
{
    DisplayStartingMessage();
    string _promptText = GetRandomPrompt();
    Console.WriteLine($"List as many responses you can to the following prompt:\n --- {_promptText} ---\n");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();
    List<string> responseList = new List<string>();

    DateTime startTime = DateTime.Now;

    while ((DateTime.Now - startTime).TotalSeconds < _duration)
    {
        Console.Write("> ");
        string _response = Console.ReadLine();
        responseList.Add(_response);
    }
    _count = responseList.Count;
    Console.WriteLine($"You listed {_count} items!\n");
    Console.WriteLine("\nWell done!!\n");

    DisplayEndingMessage();
}
    private Random random = new Random();

    public string GetRandomPrompt()
    {
        int _randomIndex = random.Next(_prompts.Count);
        string _promptText = _prompts[_randomIndex];
        return _promptText;
    }

    
    
}