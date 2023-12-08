

public class Running : Activity
{
    private double _distance;

    public Running(string date, int durationMin, string activityType, double distance) : base(date, durationMin, activityType)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60; 
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distance:f2} km, Speed: {GetSpeed():f2} kph, Pace: {GetPace():f2} min per km.";
    }
}