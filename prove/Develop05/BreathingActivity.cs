using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < _duration / 8; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}