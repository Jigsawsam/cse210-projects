public class ConcreteExerciseTracker : ExerciseTracker
{
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