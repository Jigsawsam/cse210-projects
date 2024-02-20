using System;

public abstract class WeightTracker : Tracker
{
    private double _initialWeightInPounds;
    private double _latestWeightInPounds;
    private DateTime _startDate;

    public WeightTracker(double initialWeightInPounds) : base()
    {
        _initialWeightInPounds = initialWeightInPounds;
        _latestWeightInPounds = initialWeightInPounds;
        _startDate = DateTime.Today;
    }

    public void LogWeight(double weightInPounds)
    {
        _latestWeightInPounds = weightInPounds;
        DateTime currentDate = DateTime.Today;

        string weightEntry = $"{currentDate:MM-dd-yyyy} - Weight: {weightInPounds} lbs";

        LogData(weightEntry);
    }

    public double CalculateProgress()
    {
        double totalWeightLossInPounds = _initialWeightInPounds - _latestWeightInPounds;
        
        TimeSpan elapsedTime = DateTime.Today - _startDate;
        int totalWeeks = (int)(elapsedTime.TotalDays / 7);

        double averageWeeklyLossInPounds = totalWeightLossInPounds / totalWeeks;
        return averageWeeklyLossInPounds;
    }

    public override string GenerateReport()
    {
        double progressInPounds = CalculateProgress();

        string report = $"Weight Tracker Report:\n" +
                        $"- Initial Weight: {_initialWeightInPounds} lbs\n" +
                        $"- Latest Weight: {_latestWeightInPounds} lbs\n" +
                        $"- Average Weekly Progress: {progressInPounds} lbs/week";

        return report;
    }
}