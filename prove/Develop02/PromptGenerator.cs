using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        
        _prompts.Add("Describe a moment that made you smile today.");
        _prompts.Add("What are three things you are grateful for right now?");
        _prompts.Add("Write about a challenge you faced and how you overcame it.");
        _prompts.Add("Reflect on a person who has positively impacted your life.");
        _prompts.Add("What are your short-term and long-term goals?");
        _prompts.Add("Describe a place that holds special memories for you.");
        _prompts.Add("Write a letter to your future self.");
        _prompts.Add("Share a book, movie, or song that deeply resonated with you recently.");
        _prompts.Add("What activities or hobbies bring you joy?");
        _prompts.Add("Reflect on a lesson you've learned recently.");
        _prompts.Add("Write about a decision you made and its outcomes.");
        _prompts.Add("Describe your ideal day from start to finish.");
        _prompts.Add("What are your strengths and how do they contribute to your life?");
        _prompts.Add("Reflect on a dream or aspiration you have for the future.");
        _prompts.Add("Write about a moment when you felt proud of yourself.");
        _prompts.Add("Explore a childhood memory that still lingers in your mind.");
        _prompts.Add("Describe a challenge you're currently facing and your approach to overcoming it.");
        _prompts.Add("Share a random act of kindness you experienced or witnessed.");
        _prompts.Add("What values are most important to you, and why?");
        _prompts.Add("Write about a skill or talent you'd like to develop.");

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}