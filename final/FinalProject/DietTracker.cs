using System;

public abstract class DietTracker : Tracker
{
    public DietTracker() : base()
    {

    }
    public void LogMeal()
    {
        Console.Write("Enter the name of the meal: ");
        string mealName = Console.ReadLine();

        Console.Write("Enter the average calories for this meal: ");
        double calories = double.Parse(Console.ReadLine());

        DateTime currentDate = DateTime.Today;

        string mealEntry = $"{currentDate:MM-dd-yyyy} - Meal: {mealName}, Average Calories: {calories}";

        LogData(mealEntry);
    }
    public abstract override string GenerateReport();
}