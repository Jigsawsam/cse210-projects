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
        double totalWeightChangeInPounds = GetLatestWeightInPounds() - _initialWeightInPounds;
        return totalWeightChangeInPounds;
    }

    public abstract override string GenerateReport();
    
    public double GetInitialWeightInPounds()
    {
        return _initialWeightInPounds;
    }
    public double GetLatestWeightInPounds()
    {
        return _latestWeightInPounds;
    }
}