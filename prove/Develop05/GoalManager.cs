using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private int _nextLevelThreshold;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _nextLevelThreshold = 1000;
    }
    public void Start()
    {
        bool exit = false;

        while (!exit)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Goal Manager Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points and you are at level {_level}.");
        Console.WriteLine($"Next level at {_nextLevelThreshold} points.\n");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("\nList of Goal Details:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nSelect a type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");

        Console.Write("Enter your choice: ");
        int goalChoice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalChoice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points, false));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter the target completion count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter the bonus points for completion: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, 0));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals recorded.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        Goal selectedGoal = _goals[goalIndex];

        if (selectedGoal.IsComplete())
        {
            Console.WriteLine("This goal is already complete.");
            return;
        }

        selectedGoal.RecordEvent();

        int pointsEarned = selectedGoal.GetPoints();

        _score += pointsEarned;

        if (_score >= _nextLevelThreshold)
        {
            LevelUp();
        }

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points");
    }
    public void SaveGoals()
    {
        Console.WriteLine("\nEnter a filename to save.(filename.txt) ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Score: {_score}");

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }
    public void LoadGoals()
    {
        Console.WriteLine("\nEnter a filename to load (filename.txt). ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (line.StartsWith("Score:"))
            {
                _score = int.Parse(line.Substring(7));
            }
            else
            {
                string[] parts = line.Split(',');

                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                switch (type)
                {
                    case "SimpleGoal":
                        bool isComplete = bool.Parse(parts[4]);
                        _goals.Add(new SimpleGoal(name, description, points, isComplete));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(name, description, points));
                        break;
                    case "ChecklistGoal":
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        int amountComplete = int.Parse(parts[6]);
                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountComplete));
                        break;
                }
            }
        }
        UpdateLevelAndThreshold();

        Console.WriteLine("Goals loaded successfully.");
    }

    public void LevelUp()
    {
        _level++;
        _nextLevelThreshold = (int)(_nextLevelThreshold * 1.1);
        Console.WriteLine($"level up!! lvl {_level}");
    }
    public void UpdateLevelAndThreshold()
    {
        _level = 1;
        int threshold = 1000;
        while (_score >= threshold)
        {
            _level++;
            threshold = (int)(threshold * 1.1);
        }

        _nextLevelThreshold = threshold;
    }
}