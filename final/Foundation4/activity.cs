

public class Activity
{
    private string _date;
    private int _durationMin;
    private string _activityType;

    public Activity(string date, int durationMin, string activityType)
    {
        _date = date;
        _durationMin = durationMin;
        _activityType = activityType;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _durationMin;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

     public virtual string GetSummary()
    {
        return $"{_date} {_activityType} ({_durationMin} min)";
    }

}