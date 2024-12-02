using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video();
        video1._title = "Understanding Linked Lists in 10 Minutes";
        video1._author = "CodeMasterPro";
        video1._length = "600";

        video1._comments.AddRange(new List<Comment>
        {
            new Comment { _name = "AliceTech123", _text = "This was super helpful! The visuals made it easy to understand linked lists. Thanks!" },
            new Comment { _name = "DevGuru99", _text = "Great explanation, but you could have covered circular linked lists too!" },
            new Comment { _name = "NerdyProgrammer", _text = "I've been struggling with this concept for weeks, but now it finally clicked. Subscribed!" },
            new Comment { _name = "LeoTheCoder", _text = "Quick and concise--perfect for last-minute revision. Great job!" }
        });

        Video video2 = new Video();
        video2._title = "How to Debug Your Code Like a Pro";
        video2._author = "DebugSensei";
        video2._length = "780";

        video2._comments.AddRange(new List<Comment>
        {
            new Comment { _name = "CodeCracker101", _text = "I never thought about stepping through my code this way. Amazing tips!" },
            new Comment { _name = "FixItFelix", _text = "You saved me hours of frustration with that print statement trick!" },
            new Comment { _name = "JuniorDevJay", _text = "Debugging has always been my weakness. This video gave me a whole new perspective." },
            new Comment { _name = "SaraHacks", _text = "Loved this! Could you do a follow-up for debugging APIs?" }
        });

        Video video3 = new Video();
        video3._title = "Top 5 AWS Security Practices for Beginners";
        video3._author = "CloudAce Tutorials";
        video3._length = "900";

        video3._comments.AddRange(new List<Comment>
        {
            new Comment { _name = "CloudFanatic", _text = "As a newbie, this was exactly what I needed to get started with AWS security!" },
            new Comment { _name = "SecureDev89", _text = "Good content, but you missed multi-factor authentication. Maybe include it next time?" },
            new Comment { _name = "AWSNinja25", _text = "This is gold for anyone starting out. Clear, practical, and well-paced!" },
            new Comment { _name = "TechieMike", _text = "The section on IAM roles was especially helpful. More beginner-friendly AWS videos, please!" }
        });
        
        videoList.AddRange(new List<Video> { video1, video2, video3 });

        Console.WriteLine();
        
        foreach (Video video in videoList)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}