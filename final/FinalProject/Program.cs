using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Manager manager = new Manager();
        manager.SetProfile();
        manager.Start();
    }
}