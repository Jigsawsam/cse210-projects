using System;

public abstract class Tracker
{
    private List<string> _data;

    public Tracker()
    {
        _data = new List<string>();
    }
    public void LogData(string data)
    {
        _data.Add(data);
    }
    public List<string> GetTrackedData()
    {
        return _data;
    }
    public void DisplayTrackedData()
    {
        Console.WriteLine("Tracked Data:");
        foreach (string item in _data)
        {
            Console.WriteLine(item);
        }
    }
    public abstract string GenerateReport();
}