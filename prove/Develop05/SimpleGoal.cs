using System;

// A simple goal completes once and pays out once.
public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(string title, string description, int points)
        : base(title, description, points)
    {
        _completed = false;
    }

    // Used when loading from a file.
    public SimpleGoal(string title, string description, int points, bool completed)
        : this(title, description, points)
    {
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (_completed)
        {
            return 0;
        }
        _completed = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal:{_title},{_description},{_points},{_completed}";
    }
}