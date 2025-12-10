public class Bicycle : Activity
{
    private double _distance;

    private int _laps;



    public Bicycle(DateOnly date, double length, double distance, int laps) : base(date, length)
    {
        _distance = distance;
        _laps = laps;
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
        return $"{_date:dd MMM yyyy} Bicycle ({_length}min)- Distance {_distance} miles, Speed {GetSpeed()}, Pace: {GetPace()}, number of laps {_laps}\n";
    }
    
}