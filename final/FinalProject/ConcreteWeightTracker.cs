public class ConcreteWeightTracker : WeightTracker
{
    private double _initialWeightInPounds;

    public ConcreteWeightTracker(double initialWeightInPounds) : base(initialWeightInPounds)
    {
        _initialWeightInPounds = initialWeightInPounds;
    }

    public override string GenerateReport()
    {
        List<string> weightData = GetTrackedData();

        if (weightData.Count == 0)
        {
            return "No weight data recorded.";
        }

        double progressInPounds = CalculateProgress();

        double weightDifference = GetLatestWeightInPounds() - _initialWeightInPounds;
        string weightStatus = weightDifference >= 0 ? "gained" : "lost";
        weightDifference = Math.Abs(weightDifference);



        string report = $"Weight Tracker Report:\n" +
                        $"- Initial Weight: {_initialWeightInPounds} lbs\n" +
                        $"- Latest Weight: {GetLatestWeightInPounds()} lbs\n" +
                        $"- Weight {weightStatus}: {weightDifference} lbs\n";

        foreach (var entry in weightData)
        {
            report += entry + "\n";
        }

        return report;
    }
}