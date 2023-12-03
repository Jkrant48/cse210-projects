

public class OutDoorGathering : Event
{
    private string _weatherForecast;

    public OutDoorGathering(string weatherForecast, string eventTitle, string eventDescription, string date, string time, Address address, 
        string eventType) : base(eventTitle, eventDescription, date, time, address, eventType)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather: {_weatherForecast}";
    }
}