using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> _library = new List<Scripture>
        {
            new Scripture(new Reference("D&C", 123, 17), "Therefore, dearly beloved brethren, let us cheerfully do all things that lie in our power; and then may we stand still, with the utmost assurance, to see the salvation of God, and for his arm to be revealed."),
            new Scripture(new Reference("4 Nephi", 1, 15, 16), "And it came to pass that there was no contention in the land, because of the love of God which did dwell in the hearts of the people. -- And there were no envyings, nor strifes, nor tumults, not whoredoms, not lyings, not murders, nor any manner of lasciviousness; and surely there could not be a happier people among all the people who had been created by the hand of God."),
            new Scripture(new Reference("Ether", 9, 20), "And thus the Lord did pour out his blessings upon this land, which was choice above all other lands; and he commanded that whoso should possess the land should possess it unto the Lord, or they should be destroyed when they were ripened in iniquity; for upon such, saith the Lord: I will pour out the fulness of my wrath."),
            new Scripture(new Reference("Matthew", 5, 9),"Blessed are the peacemakers: for they shall be called the children of God."),
            new Scripture(new Reference("Alma", 36, 3), "And now, O my son Helaman, behold, thou art in thy youth, and therefore, I beseech of thee that thou wilt hear my words and learn of me; for I do know that whosoever shall put their trust in God shall be support in their trials, and their troubles, and their afflictions, and shall be lifted up at the last day.")
        };
        Random random = new Random();
        Scripture randomScripture = _library[random.Next(_library.Count)];

        while (true)
        {
            Console.Clear(); 

            
            Console.WriteLine(randomScripture.GetDisplayText());

           
            if (randomScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program has ended.");
                break; 
            }

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();

            if (response.ToLower() == "quit")
            {
                Console.WriteLine("Thank you for using the scripture memorizer.");
                break; 
            }

            randomScripture.HideRandomWords(3);
        }

    }
}