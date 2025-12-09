public class Outdoor : Event
{
    private double _weather;
   

    public Outdoor(string title, string description, DateTime datetime, Address address, string eventType, double weather) : base(title, description, datetime, address, "Outdoor")
    {
       _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nThe weather the day of the event will be {_weather} degrees.";
    }


}