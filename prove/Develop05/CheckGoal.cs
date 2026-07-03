public class CheckGoal : SimpleGoal
{
    private int _numCompletes;
    private int _totalReq;
    private int _bonus;

    public CheckGoal(string title, string description, int points, int bonus, int totalReq) 
        : base(title, description, points)
    {
        _bonus = bonus;
        _totalReq = totalReq;
        _numCompletes = 0;
    }

    public CheckGoal(string title, string description, int points, int bonus, int totalReq, int numCompletes) 
        : base(title, description, points)
    {
        _bonus = bonus;
        _totalReq = totalReq;
        _numCompletes = numCompletes;
    }

    public override int RecordEvent()
    {
        if (_numCompletes < _totalReq)
        {
            _numCompletes++;
            
            if (_numCompletes >= _totalReq)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0; 
    }

    public override string GetDisplayString()
    {
        string checkbox = _numCompletes >= _totalReq ? "[X]" : "[ ]";
        return $"{checkbox} {_title} ({_description}) -- Currently completed: {_numCompletes}/{_totalReq}";
    }

    public override string GetSaveString()
    {
        return $"CheckGoal:{_title}|{_description}|{_points}|{_bonus}|{_totalReq}|{_numCompletes}";
    }
}