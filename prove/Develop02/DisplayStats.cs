public class DisplayStats
{
    public List<Entry> _entries;

    public DisplayStats(List<Entry> entries)
    {
        _entries = entries;
    }

    public void DisplayStatistics()
    {
        Console.WriteLine("Quick Stats:");

        int totalEntries = _entries.Count;
        Console.WriteLine($"Total Entries: {totalEntries}");

        if (totalEntries > 0)
        {
            int totalWords = _entries.Sum(entry => entry._entryText.Split(' ').Length);
            double averageWords = (double)totalWords / totalEntries;

            Console.WriteLine($"Total Words: {totalWords}");
            Console.WriteLine($"Average Words per Entry: {averageWords:F2}");
        }
        else
        {
            Console.WriteLine("No entries yet.");
        }

        Console.WriteLine("---------------");
    }
}