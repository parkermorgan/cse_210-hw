using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 101);

        string response = "yes";

        while (response == "yes")
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            int guessNum = int.Parse(guessString);

            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNum == magicNum)
            {
                Console.WriteLine("You guessed it!");

            }
        }

    }
}