public class Swimming : Activity
{
    private double _laps;



    public Swimming (DateOnly date, double length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    public double CalculateSpeed()
    {
        double speedCalculated = (CalculateDistance() / _length) * 60;
        double rounded = Math.Round(speedCalculated, 2);
        return rounded;
    }

    public double CalculatePace()
    {
        double minPerMile = CalculateDistance() / _length;
        double calculatedPace = minPerMile / CalculateDistance();
        double rounded = Math.Round(calculatedPace, 2);
        return rounded;
    }

    public double CalculateDistance()
    {
        double distanceCalculated = (_laps * 50) / 1000 * 0.62;
        double rounded = Math.Round(distanceCalculated, 2);
        return rounded;
    }
    public override string GetDistance()
    {
        return $"{CalculateDistance()} miles";
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
        return $"{_date:dd MMM yyyy} Swimming ({_length}min)- Distance {GetDistance()} miles, Speed {GetSpeed()}, Pace: {GetPace()}\n";
    }
    
}