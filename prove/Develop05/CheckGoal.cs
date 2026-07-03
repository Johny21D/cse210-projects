using System;

// A checklist goal must be recorded _totalReq times. Each record earns
// _points; the final record also earns _bonus.
// Completion is COMPUTED from the counts -- no _completed field needed.
public class CheckGoal : Goal
{
    private int _bonus;
    private int _numCompletes;
    private int _totalReq;

    public CheckGoal(string title, string description, int points, int bonus, int totalReq)
        : base(title, description, points)
    {
        _bonus = bonus;
        _totalReq = totalReq;
        _numCompletes = 0;
    }

    // Used when loading a goal with progress already made.
    public CheckGoal(string title, string description, int points, int bonus, int totalReq, int numCompletes)
        : this(title, description, points, bonus, totalReq)
    {
        _numCompletes = numCompletes;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _numCompletes++;
        if (_numCompletes == _totalReq)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override bool IsComplete()
    {
        return _numCompletes >= _totalReq;
    }

    public override string GetDisplayString()
    {
        string box = IsComplete() ? "[X]" : "[ ]";
        return $"{box} {_title} ({_description}) -- Completed {_numCompletes}/{_totalReq} times";
    }

    public override string GetSaveString()
    {
        return $"CheckGoal:{_title},{_description},{_points},{_bonus},{_totalReq},{_numCompletes}";
    }
}