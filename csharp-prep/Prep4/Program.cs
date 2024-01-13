using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

         int input = -1;

          while (input != 0)
          {
            Console.Write("Enter number: ");
            string inputNumber = Console.ReadLine();
            input = int.Parse(inputNumber);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        int average = 0;
        if (numbers.Count > 0)
        {
            average = sum / numbers.Count;
        }

        int max = 0;
        if (numbers.Count > 0)
        {
            max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");
    }
}