public abstract class Activity
{
    private string _date;
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public double GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {this.GetType().Name} {_minutes} minutes - " + $"Distance {GetDistance():0.0} miles, " + $"Speed {GetSpeed():0.0} mph, " + $"Pace {GetPace()} min per mile";
    }
}