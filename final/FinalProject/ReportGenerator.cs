using System;

public class ReportGenerator
{
    public string GenerateWeightReport(double initialWeight, double latestWeight)
    {
        double weightChange = initialWeight - latestWeight;
        string report = $"Weight Tracker Report:\n" +
                        $"- Initial Weight: {initialWeight} lbs\n" +
                        $"- Latest Weight: {latestWeight} lbs\n" +
                        $"- Weight Change: {weightChange} lbs";
        return report;
    }

    public string GenerateExerciseReport(string activity, double duration, double caloriesBurned)
    {
        string report = $"Exercise Tracker Report:\n" +
                        $"- Activity: {activity}\n" +
                        $"- Duration: {duration} hours\n" +
                        $"- Calories Burned: {caloriesBurned} kcal";
        return report;
    }

    public string GenerateDietReport(string mealName, double averageCalories)
    {
        string report = $"Diet Tracker Report:\n" +
                        $"- Meal: {mealName}\n" +
                        $"- Average Calories: {averageCalories} kcal";
        return report;
    }
}