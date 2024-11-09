using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        Random randomGenerator = new Random();

        while (response == "yes")
        {
            int magicNum = randomGenerator.Next(1, 101);
            bool guessedCorrectly = false;

            Console.WriteLine("A new game has started! Try to guess the magic number between 1 and 100.");

            while (!guessedCorrectly)
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
                else
                {
                    Console.WriteLine("You guessed it!");
                    guessedCorrectly = true;  // Exit the guessing loop
                }
            }

            // Ask to play again only after the correct guess
            Console.Write("Would you like to play again? (yes/no): ");
            response = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}