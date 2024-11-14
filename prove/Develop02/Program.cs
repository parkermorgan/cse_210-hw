using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();

       
        string prompt = promptGenerator.GetRandomPrompt();
        anEntry.SetPrompt(prompt);  

        Console.WriteLine("Hello Develop02 World!");
        anEntry.Display();  
    }
}