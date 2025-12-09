public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime datetime, Address address, string eventType, string speaker, int capacity) : base(title, description, datetime, address, "Lecture")
    {
       _speaker = speaker;
       _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nThe speaker is {_speaker}. The Capacity of the Lecture is {_capacity}";
    }

}