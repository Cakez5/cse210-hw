using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters
    public int Top
    {
        get { return _top; }
        set { _top = value; }
    }

    public int Bottom
    {
        get { return _bottom; }
        set 
        { 
            if (value == 0) 
                throw new ArgumentException("Denominator cannot be zero."); 
            _bottom = value; 
        }
    }

    // Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}