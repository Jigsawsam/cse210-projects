using System;

public class Manager
{
    private Profile userProfile;
    private WeightTracker weightTracker;
    private ExerciseTracker exerciseTracker;
    private DietTracker dietTracker;
    private ReportGenerator reportGenerator;

    public Manager()
    {
        userProfile = new Profile(0, 0, 0.0, "");
        weightTracker = new WeightTracker();
        exerciseTracker = new ExerciseTracker();
        dietTracker = new DietTracker();
        reportGenerator = new ReportGenerator();
    }

    public void Start()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Create Profile");
            Console.WriteLine("2. Log Weight");
            Console.WriteLine("3. Log Exercise");
            Console.WriteLine("4. Log Meal");
            Console.WriteLine("5. View Report");
            Console.WriteLine("6. Exit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SetProfile();
                    break;
                case 2:
                    LogWeight();
                    break;
                case 3:
                    LogExercise();
                    break;
                case 4:
                    LogMeal();
                    break;
                case 5:
                    GenerateReport();
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

    public void SetProfile()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter your height (cm): ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Enter your weight (lbs): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Enter your goal: ");
        string goal = Console.ReadLine();

        userProfile.SetProfile(age, height, weight, goal);
    }

    public void LogWeight()
    {
        Console.Write("Enter your weight (lbs): ");
        double weight = double.Parse(Console.ReadLine());
        weightTracker.LogWeight(weight);
    }

    public void LogExercise()
    {
        exerciseTracker.LogExercise();
    }

    public void LogMeal()
    {
        dietTracker.LogMeal();
    }

    public void GenerateReport()
    {
        Console.WriteLine("1. Weight Report");
        Console.WriteLine("2. Exercise Report");
        Console.WriteLine("3. Diet Report");
        Console.Write("Select a report to view: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine(reportGenerator.GenerateWeightReport(weightTracker.InitialWeightInPounds, weightTracker.LatestWeightInPounds));
                break;
            case 2:
                Console.WriteLine(exerciseTracker.GenerateReport());
                break;
            case 3:
                Console.WriteLine(dietTracker.GenerateReport());
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}