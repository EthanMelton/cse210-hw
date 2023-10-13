using System;

public class Fraction
{
    // private properties
    private int _top;
    private int _bottom;

    //constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int whole)
    {
        _top = whole;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //methods
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top/(double)_bottom;
        return decimalValue;
    }
}