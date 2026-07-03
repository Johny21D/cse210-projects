using System;
public abstract class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();


    public abstract bool IsComplete();

    public abstract string GetSaveString();

    public virtual string GetDisplayString()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {_title} ({_description})";
    }
}