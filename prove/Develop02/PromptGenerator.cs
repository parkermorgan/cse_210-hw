using System;
using System.Collections.Generic;

public class PromptGenerator
{
 
    public List<string> _prompts = new List<string> 
    { 
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Was there anything that caused me stress today?",
        "Is there someone who you feel like you should reach out to?",
        "Is there anything I did today that I should keep doing?",
        "Did I feel the spirit today?"
    };

    private Random random = new Random();

    public string GetRandomPrompt()
    {     
        int _randomIndex = random.Next(_prompts.Count);

        string _promptText = _prompts[_randomIndex];
        
        return _promptText;
    }
}