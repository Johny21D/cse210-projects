using System;

// An eternal goal is never finished. Every record earns points.
// Notice it has NO _completed field at all -- it doesn't need one.
public class EternalGoal : Goal
{
    public EternalGoal(string title, string description, int points)
        : base(title, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetSaveString()
    {
        return $"EternalGoal:{_title},{_description},{_points}";
    }
}