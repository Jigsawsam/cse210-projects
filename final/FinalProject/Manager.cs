using System;

public class Manager
{
    private Profile _userProfile;
    private ConcreteWeightTracker _weightTracker;
    private ConcreteExerciseTracker _exerciseTracker;
    private ConcreteDietTracker _dietTracker;


    public Manager()
    {
        _userProfile = new Profile(0, 0, 0.0, "");
        _weightTracker = null;
        _exerciseTracker = new ConcreteExerciseTracker();
        _dietTracker = new ConcreteDietTracker();
    }

    public void Start()
    {
        bool exit = false;

        while (!exit)
        {
            string message = MotivationalMessage.GetRandomMessage();
            Console.WriteLine($"{message}");
            Console.WriteLine();
            Console.WriteLine("1. Log Weight");
            Console.WriteLine("2. Log Exercise");
            Console.WriteLine("3. Log Meal");
            Console.WriteLine("4. View Report");
            Console.WriteLine("5. Exit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LogWeight();
                    break;
                case 2:
                    LogExercise();
                    break;
                case 3:
                    LogMeal();
                    break;
                case 4:
                    GenerateReports();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void SetProfile()
    {
        Console.WriteLine("Create a Profile\n");

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your height (ft): ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter your weight (lbs): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter your goal: ");
        string goal = Console.ReadLine();
        Console.WriteLine();

        _userProfile.SetProfile(age, height, weight, goal);
        _weightTracker = new ConcreteWeightTracker(weight);

    }

    public void LogWeight()
    {
        Console.Write("\nEnter your weight (lbs): ");
        double weight = double.Parse(Console.ReadLine());
        _weightTracker.LogWeight(weight);
        Console.WriteLine("\nWeight logged\n");
    }

    public void LogExercise()
    {
        _exerciseTracker.LogExercise();
        Console.WriteLine("Exercise logged\n");
    }

    public void LogMeal()
    {
        _dietTracker.LogMeal();
        Console.WriteLine("\nMeal logged\n");
    }

    public void GenerateReports()
    {

        Console.WriteLine("\n1. Weight Report");
        Console.WriteLine("2. Exercise Report");
        Console.WriteLine("3. Diet Report");
        Console.WriteLine("4. View All");
        Console.Write("Select a report to view: ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        switch (choice)
        {
            case 1:
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(_weightTracker.GenerateReport());
                Console.WriteLine("----------------------------------------------------");
                break;
            case 2:
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(_exerciseTracker.GenerateReport());
                Console.WriteLine("----------------------------------------------------");
                break;
            case 3:
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine(_dietTracker.GenerateReport());
                Console.WriteLine("----------------------------------------------------");
                break;
            case 4:
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine(_weightTracker.GenerateReport());
                Console.WriteLine(_exerciseTracker.GenerateReport());
                Console.WriteLine(_dietTracker.GenerateReport());
                Console.WriteLine("--------------------------------------------------------");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}