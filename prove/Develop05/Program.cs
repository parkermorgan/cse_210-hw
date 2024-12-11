//PREFACE: ChatGPT was used to assist in creating the spinner icon, and answering questions regarding clearing text, formatting the countdown timer, and figuring out datetime commands.

using System;

class Program
{
    static void Main(string[] args)
    {
        bool looping = true;

        while(looping)
        {
            Console.WriteLine("Menu Options:");
            Console.Write(" 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\n\nSelect a choice from the menu: ");
            string menuInput = Console.ReadLine();
            Console.WriteLine("");

            if(menuInput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }

            else if(menuInput == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }

            else if(menuInput == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }

            else if(menuInput == "4")
            {
                looping = false;
            }

            else
            {
                Console.WriteLine("Incorrect value.");
            }
        }
    }
}