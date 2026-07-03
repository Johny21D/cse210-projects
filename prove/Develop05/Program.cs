// EXCEEDING REQUIREMENT: Leveling system.
// Every 1000 points the user goes up one level. The level is shown
// in the menu, and a "LEVEL UP" message prints when crossing 1000
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    // The list is typed as the abstract base -- it can hold any goal type,
    // and the menu code never needs to know which is which.
    static List<Goal> _goals = new List<Goal>();
    static int _score = 0;

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            // Exceeding requirement: leveling system.
            Console.WriteLine($"\nYou have {_score} points. -- Level {GetLevel()}\n");
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
            else if (choice == "2") ListGoals();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
            else if (choice == "6") running = false;
            else Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine("Goodbye!");
    }

    // Every 1000 points is one level.
    static int GetLevel()
    {
        return (_score / 1000) + 1;
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
        string title = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(title, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(title, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished? ");
            int totalReq = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new CheckGoal(title, description, points, bonus, totalReq));
        }
    }

    static void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nThere are no goals yet.");
            return;
        }

        Console.WriteLine("\nYour goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    static void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nThere are no goals to record.");
            return;
        }

        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("That goal does not exist.");
            return;
        }

        // Polymorphism: the object decides how many points an event is worth.
        int levelBefore = GetLevel();
        int earned = _goals[index].RecordEvent();
        _score += earned;

        if (earned > 0)
        {
            Console.WriteLine($"Congratulations! You earned {earned} points! You now have {_score}.");
        }
        else
        {
            Console.WriteLine("That goal is already complete -- no points earned.");
        }

        if (GetLevel() > levelBefore)
        {
            Console.WriteLine($"*** LEVEL UP! You are now Level {GetLevel()}! ***");
        }
    }

    static void SaveGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetSaveString());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    static void LoadGoals()
    {
        Console.Write("\nWhat is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string[] data = parts[1].Split(',');

            if (parts[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
            else if (parts[0] == "CheckGoal")
            {
                _goals.Add(new CheckGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}