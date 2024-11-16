using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        Journal theJournal = new Journal(promptGenerator);
    
        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string _selectStr = Console.ReadLine();

            if (int.TryParse(_selectStr, out int _select))
            {
                // If parsing is successful, continue with the chosen action
                if (_select == 1)  // Adds an entry to the list
                {
                    theJournal.AddEntry();
                }
                else if (_select == 2) // Displays all entries
                {
                    theJournal.DisplayAll();
                }
                else if (_select == 3) // Loads entries from a file
                {
                    theJournal.LoadFromFile();
                }
                else if (_select == 4) // Saves entries to a file
                {
                    theJournal.SaveToFile();
                }
                else if (_select == 5) // Quits the program
                {
                    Console.WriteLine("Thank you for using the journal.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
          
    }
}