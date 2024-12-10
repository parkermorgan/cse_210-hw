using System;

class Program
{
    static void Main(string[] args)
    {
        bool looping = true;

        while(looping)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\nSelect a choice from the menu: ");
            string menuInput = Console.ReadLine();
        }
    }
}