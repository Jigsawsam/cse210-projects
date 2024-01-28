using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        ScriptureManager scriptureManager = new ScriptureManager();
        List<Scripture> scriptures = scriptureManager.GetScriptures();

        Random random = new Random();
        Scripture currentScripture = scriptures[random.Next(scriptures.Count)];

        Console.WriteLine(currentScripture.GetDisplayText());
        Console.WriteLine();

        bool allHidden = false;

        do
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit...");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Exiting program...");
                return;
            }

            Console.Clear();

            currentScripture.HideRandomWords(1, random);

            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();

            allHidden = currentScripture.IsCompletelyHidden();
        } while (!allHidden);
    }
}