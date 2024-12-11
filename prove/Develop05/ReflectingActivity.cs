using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

public class ReflectingActivity : Activity
{
  public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

  private List<string> _prompts = new List<string>
  {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
  };
  private List<string> _questions = new List<string>
  {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
  };

  private Random random = new Random();
  public override void Run()
  {
    DisplayStartingMessage();

    string promptText = GetRandomPrompt();
    Console.WriteLine($"Consider the following prompt:\n\n{promptText}");

    Console.WriteLine("When you have something in mind, press 'enter' to continue.");
    Console.ReadLine();

    Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
    Console.Write("You may begin in: ");
    ShowCountDown(5);
    Console.Clear();

    DateTime startTime = DateTime.Now;

    while ((DateTime.Now - startTime).TotalSeconds < _duration)
    {
      DisplayQuestions();
    }

    Console.WriteLine("\nWell done!!\n");

    DisplayEndingMessage();
  }
  public string GetRandomPrompt()
  {
    int _randomIndex = random.Next(_prompts.Count);
    string _promptText = _prompts[_randomIndex];
    return _promptText;
  } 
  public string GetRandomQuestion()
  {
    int _randomIndexQuestion = random.Next(_questions.Count);
    string _questionText = _questions[_randomIndexQuestion];
    return _questionText;
  } 
  public void DisplayPrompt()
  {
    string promptText = GetRandomPrompt();
    Console.WriteLine($"--- {promptText} ---");
  }
  public void DisplayQuestions()
  {
      string question = GetRandomQuestion();
      Console.Write($"> {question} ");
      ShowSpinner(5); 
      Console.WriteLine("");
  }
}