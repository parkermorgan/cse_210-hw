using System;

class Program
{
    static void Main(string[] args)
    {
        bool looping = true;

        while(looping)
        {
            Console.WriteLine("Menu Options:");
            Console.Write(" 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\nSelect a choice from the menu: ");
            string menuInput = Console.ReadLine();
            Console.WriteLine("");

            if(menuInput == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 30);
                breathingActivity.Run();
            }

            if(menuInput == "4")
            {
                looping = false;
            }
        }
    }
}