public abstract class Activity
{
    protected DateOnly _date;
    protected double _length;

  
    public Activity(DateOnly date, double length)
    {
        _date = date;
        _length = length;
        
    }

    public abstract string GetDistance();
    public abstract string GetSpeed();
    public abstract string GetPace();

    public abstract string GetSummary();
}