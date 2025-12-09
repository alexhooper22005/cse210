public class Reception : Event
{
    private string _rsvp;
   

    public Reception(string title, string description, DateTime datetime, Address address, string eventType, string rsvp) : base(title, description, datetime, address, "Reception")
    {
       _rsvp = rsvp;
      
    }
    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nThe email to rsvp is {_rsvp}.";
    }
    

}