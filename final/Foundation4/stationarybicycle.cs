

public class StationaryBicycle : Activity
{
     
    private double _speed;
    private double _distance;

    public StationaryBicycle(string date, int durationMinutes,string activityType ,double speed, double distance)
        : base(date, durationMinutes, activityType)
    {
        _speed = speed;
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return _speed;
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