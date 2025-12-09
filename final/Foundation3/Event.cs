public class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, DateTime datetime, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _dateTime = datetime;
        _address = address;
        _eventType = eventType;
    }

    public virtual string GetFullDetails()
    {
        return $"The event is {_title}. Description: {_description}. This is at {_dateTime}, and will be located at {_address}";
    }
    public virtual string GetShortDescription()
    {
        return $"{_eventType}. {_title}. This is at {_dateTime}.";
    }
    public string GetStandardDetails()
    {
        return $"{_title}. {_description}. This is at {_dateTime}, and will be located at {_address}";
    }

}