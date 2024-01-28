using System;

public class Scripture
{
    private Reference _reference;
    public List<Word> _word;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _word = new List<Word>();
        string[] words = text.Split(' '); 

        foreach (string wordText in words)
        {
            _word.Add(new Word(wordText));
        }   
    }

public void HideRandomWords(int hideAmount, Random random)
{
    for (int i = 0; i < hideAmount && i < _word.Count; i++)
    {
        int index;
        
        do
        {
            index = random.Next(_word.Count);
        } 
        while (_word[index].IsHidden());
        _word[index].Hide();
    }
}

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _word)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false; 
            }
        }

        Console.WriteLine("All words are hidden. Exiting program.");
        Environment.Exit(0);
        return true;
    }
}