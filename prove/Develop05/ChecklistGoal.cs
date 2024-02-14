using System;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountComplete) : base(name, description, points)
    {
        _amountComplete = amountComplete;
        _target = target;
        _bonus = bonus;
    } 
    public override void RecordEvent()
    {
        _amountComplete++;
    
        if (_amountComplete >= _target)
        {
            _points += _bonus;
        }
    }
    public override bool IsComplete()
    {
        return _amountComplete >= _target;
    }
    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description}) --- Currently completed {_amountComplete}/{_target}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_target},{_bonus},{_amountComplete}";
    }
}