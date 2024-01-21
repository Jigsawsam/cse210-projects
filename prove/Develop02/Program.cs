using System;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        DisplayStats statsDisplay = new DisplayStats(myJournal._entries);

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quick Stats");
            Console.WriteLine("0. Exit");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {entry._promptText}");
                Console.WriteLine("Enter a new entry:");
                entry._entryText = Console.ReadLine();
                myJournal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to save the journal:");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter the filename to load the journal:");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                statsDisplay.DisplayStatistics();
            }

        } while (choice != "0");

        Console.WriteLine("Exited the Journal.");
    }
}