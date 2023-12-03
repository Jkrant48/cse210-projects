

public class Reception : Event
{
    public string _rsvp;

    public Reception(string rsvp, string eventTitle, string eventDescription, string date, string time, Address address, 
        string eventType) : base (eventTitle, eventDescription, date, time, address, eventType)
    {
        _rsvp = rsvp;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nRSVP: {_rsvp}";
    }
}