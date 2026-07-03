public class SimpleGoal
{
    protected string _title;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public SimpleGoal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
        _completed = false;
    }

    public virtual int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _points;
        }
        return 0; 
    }

    public virtual string GetDisplayString()
    {
        string checkbox = _completed ? "[X]" : "[ ]";
        return $"{checkbox} {_title} ({_description})";
    }

    public virtual string GetSaveString()
    {
        return $"SimpleGoal:{_title}|{_description}|{_points}|{_completed}";
    }
}