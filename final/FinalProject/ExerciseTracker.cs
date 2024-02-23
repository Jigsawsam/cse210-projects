using System;

public abstract class ExerciseTracker : Tracker
{
    public ExerciseTracker() : base()
    {

    }
    public void LogExercise()
    {
        Console.WriteLine("\nChoose an exercise activity:");
        Console.WriteLine("1. Running");
        Console.WriteLine("2. Cycling");
        Console.WriteLine("3. Swimming");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        string activity = "";
        switch (choice)
        {
            case 1:
                activity = "Running";
                break;
            case 2:
                activity = "Cycling";
                break;
            case 3:
                activity = "Swimming";
                break;
        }

        Console.Write("Enter the duration of the activity (in hours): ");
        double duration = double.Parse(Console.ReadLine());

        double caloriesBurned = CalculateCaloriesBurned(activity, duration);

        string exerciseEntry = $"{DateTime.Today:MM-dd-yyyy} - Exercise: {activity}, Duration: {duration} hours, Avg kcal burned {caloriesBurned}";
        LogData(exerciseEntry);

        Console.WriteLine($"\n---Calories burned: {caloriesBurned} kcal---");
    }

    public double CalculateCaloriesBurned(string activity, double duration)
    {
        double caloriesBurnedPerHour = 0.0;

        switch (activity.ToLower())
        {
            case "running":
                caloriesBurnedPerHour = 600;
                break;
            case "cycling":
                caloriesBurnedPerHour = 500;
                break;
            case "swimming":
                caloriesBurnedPerHour = 700;
                break;
        }

        double caloriesBurned = caloriesBurnedPerHour * duration;
        return caloriesBurned;
    }

    public abstract override string GenerateReport();
}