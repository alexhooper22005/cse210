public class Running : Activity
{
    private double _distance;



    public Running(DateOnly date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    public double CalculateSpeed()
    {
        double speedCalculated = (_distance / _length) * 60;
        double rounded = Math.Round(speedCalculated, 2);
        return rounded;
    }

    public double CalculatePace()
    {
        double minPerMile = _distance / _length;
        double calculatedPace = minPerMile / _distance;
        double rounded = Math.Round(calculatedPace, 2);
        return rounded;
    }
    public override string GetDistance()
    {
        return $"{_distance} miles";
    }  

    public override string GetPace()
    {
        return $"{CalculatePace()} min per mile";
    }

    public override string GetSpeed()
    {
        return $"{CalculatePace()} mph";
    }

    public override string GetSummary()
    {
        return $"{_date:dd MMM yyyy} Running ({_length}min)- Distance {_distance} miles, Speed {GetSpeed()}, Pace: {GetPace()}\n";
    }
    
}