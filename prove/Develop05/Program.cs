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
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                breathingActivity.Run();
            }

            else if(menuInput == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0);
                reflectingActivity.Run();
            }

            else if(menuInput == "3")
            {
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0);
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