using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string percentInput = Console.ReadLine();
        int percent = int.Parse(percentInput);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if( percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed better luck next time!");
        }
        int lastDigit = percent % 10;
            string sign = "";

        if (lastDigit >= 7)
            sign = "+";
        else if (lastDigit < 3)
            sign = "-";

        if (letter == "A" && sign == "+")
        {
            letter = "A";
            sign = "";
        }
        else if (letter == "F" && sign == "+")
        {
            letter = "F";
            sign = "";
        }
       
        Console.WriteLine($"Your final grade is {letter}{sign}");  
        
    }
}