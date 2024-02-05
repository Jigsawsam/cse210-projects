using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"\nBreath in   ");
            BreathInAnim(5);
            Console.WriteLine();
            
            Console.Write($"\nBreath out   ");
            BreathOutAnim(5);
            Console.WriteLine();
        }   
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(4);

        Console.Clear();
    }
    public void BreathInAnim(int seconds)
    {
        List <string> animationStrings = new List<string>();
        animationStrings.Add("○");
        animationStrings.Add("◎");
        animationStrings.Add("⦿");
        animationStrings.Add("◉");
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1400);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void BreathOutAnim(int seconds)
    {
        List <string> animationStrings = new List<string>();
        animationStrings.Add("◉");
        animationStrings.Add("⦿");
        animationStrings.Add("◎");
        animationStrings.Add("○");
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1400);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
}