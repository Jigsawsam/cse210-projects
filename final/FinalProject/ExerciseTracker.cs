using System;

public abstract class ExerciseTracker : Tracker
{
    public ExerciseTracker() : base()
    {

    }
    public void LogExercise()
    {
        Console.WriteLine("Choose an exercise activity:");
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

        string exerciseEntry = $"{DateTime.Today:MM-dd-yyyy} - Exercise: {activity}, Duration: {duration} hours";
        LogData(exerciseEntry);

        double caloriesBurned = CalculateCaloriesBurned(activity, duration);
        Console.WriteLine($"Calories burned: {caloriesBurned} kcal");
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

    public override string GenerateReport()
    {
        List<string> exerciseData = GetTrackedData();

        if (exerciseData.Count == 0)
        {
            return "No exercise data recorded.";
        }

        string report = "Exercise Tracker Report:\n";

        foreach (string entry in exerciseData)
        {
            report += entry + "\n";
        }

        return report;
    }
}