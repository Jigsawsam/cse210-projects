using System;

public class ListActivity : Activity
{
    private List<string> _prompts;

    public ListActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "---Who are people that you appreciate?---",
            "---What are personal strengths of yours?---",
            "---Who are people that you have helped this week?---",
            "---When have you felt the Holy Ghost this month?---",
            "---Who are some of your personal heroes?---"
        };
    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine(); 
        Console.WriteLine("\nList as many responses you can to the following prompt:\n");

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);

        Console.Write("\nYou may begin in... "); 
        ShowCountDown(9);

        Console.WriteLine("Go!");

        List<string> responses = GetListFromUser();

        Console.WriteLine($"\nYou have listed {responses.Count} items!");

        Console.WriteLine(); 
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine(); 
        DisplayEndingMessage();
        ShowSpinner(4);

        Console.Clear();
    }
    public string GetRandomPrompt()
    {
        if (_prompts.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
        return "";
    }
    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            list.Add(response);
        }

        return list;
    }
}