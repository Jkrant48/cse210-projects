

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventTitle, string eventDescription, string date, string time, Address address, 
        string eventType, string speaker, int capacity): base(eventTitle, eventDescription, date, time, address, eventType)
    {
        _capacity = capacity;
        _speaker = speaker;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nEventType: {GetEventType()}, Speaker: {_speaker}, Capacity: {_capacity} Attendees.";
    }
}