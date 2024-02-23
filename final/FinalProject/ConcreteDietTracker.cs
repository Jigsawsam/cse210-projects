public class ConcreteDietTracker : DietTracker
{
    public override string GenerateReport()
    {
        List<string> dietData = GetTrackedData();

        if (dietData.Count == 0)
        {
            return "No diet data recorded.";
        }

        string report = "Diet Tracker Report:\n";

        foreach (string entry in dietData)
        {
            report += entry + "\n";
        }

        return report;
    }
}