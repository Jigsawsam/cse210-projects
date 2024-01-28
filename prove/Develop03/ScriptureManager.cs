using System;

public class ScriptureManager
{
    private List<Scripture> _scriptures;

    public ScriptureManager()
    {
        _scriptures = new List<Scripture>();
        BuildScriptures();  
    }

    private void BuildScriptures()
    {
        Reference reference1 = new Reference("James", 1, 5);
        Reference reference2 = new Reference("Moroni", 10, 4, 5);
        Reference reference3 = new Reference("Jacob", 6, 12);
        Reference reference4 = new Reference("Psalm", 111, 2);
        Reference reference5 = new Reference("3 Nephi", 18, 19, 20);

        Scripture scripture1 = new Scripture(reference1, "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.");
        Scripture scripture2 = new Scripture(reference2, "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.");
        Scripture scripture3 = new Scripture(reference3, "O be wise; what can I say more?");
        Scripture scripture4 = new Scripture(reference4, "The works of the Lord are great, sought out of all them that have pleasure therein.");
        Scripture scripture5 = new Scripture(reference5, "Therefore ye must always pray unto the Father in my name; And whatsoever ye shall ask the Father in my name, which is right, believing that ye shall receive, behold it shall be given unto you.");

        _scriptures.Add(scripture1);
        _scriptures.Add(scripture2);
        _scriptures.Add(scripture3);
        _scriptures.Add(scripture4);
        _scriptures.Add(scripture5);

    }

    public List<Scripture> GetScriptures()
    {
        return _scriptures;
    }
}