using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public abstract void Run();
    
    public Activity()
    {
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.Write($"{_description}\n\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.Write(" ");
        Console.WriteLine("\n\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);
        Console.WriteLine("");
    }
    public void ShowSpinner(int seconds)
    {
        string[] _spinner = { "|", "/", "-", "\\"};

        for (int i = 0; i < seconds * 10; i++)
        {
            Console.Write(_spinner[i % _spinner.Length]);
            Thread.Sleep(100); 
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.Write("\b");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {    
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b"); 

            if (i == 1)
            {
                Console.Write(" ");
            }
        } 
        Console.WriteLine();
    }

}