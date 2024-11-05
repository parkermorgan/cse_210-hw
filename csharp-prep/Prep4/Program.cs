using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        bool looping = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (looping)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            int responseNum = int.Parse(response);

            if (responseNum != 0)
            {
                numbers.Add(responseNum);
            }
            else if (responseNum == 0)
            {
                double sum = 0;

                int max = numbers[0];

                foreach (int number in numbers)
                {
                    if (number > max)
                    {
                        max = number;
                    }
                }

                foreach (int number in numbers)
                {
                    sum += number;
                }
                double avg = sum / numbers.Count;

                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {avg}");
                Console.WriteLine($"The largest number is: {max}");
                
                looping = false;
            }

            

        }
    }
}