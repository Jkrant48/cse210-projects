

public class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string eventTitle, string eventDescription, string date, string time, Address address, string eventType)
    {
        _address = address;
        _date = date;
        _eventDescription = eventDescription;
        _eventTitle = eventTitle;
        _time = time;
        _eventType = eventType;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {_eventTitle}\t\tEvent Description: {_eventDescription}\nDate: {_date}\t\tTime: {_time}\nAddress: {_address.DisplayAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public string GetShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_eventTitle}\nDate: {_date}";
    }
}