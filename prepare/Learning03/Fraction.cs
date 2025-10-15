using System;

class Fraction
{
    private int topNumber;
    private int bottomNumber;


    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;

    }

    public Fraction(int top)
    {
        topNumber = top;
        bottomNumber = 1;
    }

    public Fraction(int top, int bottom)
    {
        topNumber = top;
        bottomNumber = bottom;
    }

    public string GetFractionString()
    {
        string fract = $"{topNumber}/{bottomNumber}";
        return fract;
    }

    public double GetDecimalValue()
    {
        return (double)topNumber / (double)bottomNumber;
    }
    
}