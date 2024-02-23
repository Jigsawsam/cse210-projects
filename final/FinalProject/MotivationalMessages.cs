using System;

public class MotivationalMessage
{
    private static string[] messages = {
        "Believe in yourself and all that you are. Know that there is something inside you that is greater than any obstacle.",
        "Success is not final, failure is not fatal: It is the courage to continue that counts.",
        "The only way to do great work is to love what you do. If you haven't found it yet, keep looking. Don’t settle.",
        "Hardships often prepare ordinary people for an extraordinary destiny.",
        "The only limit to our realization of tomorrow will be our doubts of today.",
        "The greatest glory in living lies not in never falling, but in rising every time we fall.",
        "The future belongs to those who believe in the beauty of their dreams.",
        "Your time is limited, don't waste it living someone else's life. Don't be trapped by dogma – which is living with the results of other people's thinking."
    };

    private static Random random = new Random();

    public static string GetRandomMessage()
    {
        int index = random.Next(messages.Length);
        return messages[index];
    }
}