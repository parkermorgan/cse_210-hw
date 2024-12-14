//PREFACE: ChatGPT was used for adding index numbers to ListGoalDetails(), checklist information in RecordEvent(), and splitting up string information and goal type in LoadGoals().

using System.Formats.Asn1;
using System.Runtime.ExceptionServices;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void AddBonusPoints(int bonusPoints)
    {
        _score += bonusPoints;
    }

    public void Start()
    {
        bool looping = true;

        while(looping)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                CreateGoal();
            }
            else if (response == "2")
            {
                Console.WriteLine();
                ListGoalDetails();
            }
            else if (response == "3")
            {
                SaveGoals();
            }
            else if (response == "4")
            {
                LoadGoals();
            }
            else if (response == "5")
            {
                RecordEvent();
            }
            else if (response == "6")
            {
                Console.WriteLine("Thank you for using the program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string choice = Console.ReadLine();
        Goal newGoal = null;

        Console.WriteLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string _pointsString = Console.ReadLine();
        int points = int.Parse(_pointsString);

        if (choice == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (choice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string _countString = Console.ReadLine();
            int count = int.Parse(_countString);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string _bonusString = Console.ReadLine();
            int bonus = int.Parse(_bonusString);

            newGoal = new ChecklistGoal(name, description, points, count, bonus, this);
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }

        _goals.Add(newGoal);
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].getName()}");
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("There are no goals to accomplish.");
            return;
        }

        ListGoalNames();

        string choiceString = Console.ReadLine();
        int goalChoice = int.Parse(choiceString);

        Goal goal = _goals[goalChoice - 1];
        goal.RecordEvent();
        _score += goal.GetPoints();

        Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Your information has been saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        if(!File.Exists(fileName))
        {
            Console.WriteLine("No file found.");
            return;
        }

        using (StreamReader inputFile = new StreamReader(fileName))
        {
            _score = int.Parse(inputFile.ReadLine());

            _goals.Clear();

            while (!inputFile.EndOfStream)
            {
                string goalContent = inputFile.ReadLine();
                string[] goalSplit = goalContent.Split('|');

                string name = goalSplit[1];
                string description = goalSplit[2];
                int points = int.Parse(goalSplit[3]);

                Goal goal = null;
                if (goalSplit[0] == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(goalSplit[4]);
                    goal = new SimpleGoal(name, description, points);
                    goal.SetIsComplete(isComplete);
                }
                else if (goalSplit[0] == "EternalGoal")
                {
                    goal = new EternalGoal(name, description, points);
                }
                else if (goalSplit[0] == "ChecklistGoal")
                {
                    int count = int.Parse(goalSplit[5]);
                    int bonus = int.Parse(goalSplit[6]);
                    bool isComplete = bool.Parse(goalSplit[7]);
                    goal = new ChecklistGoal(name, description, points, count, bonus,this);
                    goal.SetIsComplete(isComplete);
                }
                    _goals.Add(goal);

                    Console.WriteLine("File loaded successfully.");
                }
            }
    }
}