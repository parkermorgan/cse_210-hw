using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        Journal theJournal = new Journal(promptGenerator);
    
        Console.WriteLine("Hello Develop02 World!");
        theJournal.AddEntry();
          
    }
}