using System;

class Program
{
    static List<SimpleGoal> _goals = new List<SimpleGoal>();
    static int _totalPoints = 0;

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") DisplayGoals();
            else if (choice == "3") Save();
            else if (choice == "4") Load();
            else if (choice == "5") RecordEvent();
            else if (choice == "6") running = false;
            else Console.WriteLine("Invalid option. Please try again.");
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckGoal(name, desc, points, bonus, total));
        }
    }

    static void DisplayGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals yet.");
            return;
        }

        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDisplayString()}");
        }

        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex))
        {
            goalIndex -= 1;

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                int pointsEarned = _goals[goalIndex].RecordEvent();
                _totalPoints += pointsEarned;
                
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_totalPoints} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }
    }

    static void Save()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_totalPoints);
            
            foreach (SimpleGoal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    static void Load()
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(file);
        _goals.Clear();

        if (lines.Length > 0 && int.TryParse(lines[0], out int savedPoints))
        {
            _totalPoints = savedPoints;
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            if (parts.Length < 2) continue; 

            string type = parts[0];
            string[] data = parts[1].Split('|');

            if (type == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (bool.Parse(data[3])) { sg.RecordEvent(); _totalPoints -= int.Parse(data[2]); } 
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (type == "CheckGoal")
            {
                string title = data[0];
                string description = data[1];
                int points = int.Parse(data[2]);
                int bonus = int.Parse(data[3]);
                int totalReq = int.Parse(data[4]);
                int numCompletes = int.Parse(data[5]);
                
                _goals.Add(new CheckGoal(title, description, points, bonus, totalReq, numCompletes));
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}