using System;

public class Profile
{
    private int _age;
    private int _height;
    private double _weight;
    private string _goal;
    
    public Profile(int age, int height, double weight, string goal)
    {
         _age = age;
         _height = height;
         _weight = weight;
         _goal = goal;
    }
    public void SetProfile(int age, int height, double weight, string goal)
    {
        _age = age;
        _height = height;
        _weight = weight;
        _goal = goal;
    }
    public string GetProfile()
    {
        return $"Age: {_age}, Height: {_height} ft, Weight: {_weight} lbs, Goal: {_goal}";
    }
}