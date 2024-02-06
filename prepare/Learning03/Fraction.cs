using System;

public class Fraction
{
    // variables for top and bottom of fraction
    private int _top;
    private int _bottom;

    // no-argument constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // whole number constructor
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // fraction constructor
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // get top of fraction
    public int GetTop()
    {
        return _top;
    }

    // get bottom of fraction
    public int GetBottom()
    {
        return _bottom;
    }

    // set top of fraction
    public void SetTop(int top)
    {
        _top = top;
    }

    // set bottom of fraction
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // return the fraction as a string
    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    // convert the fraction into decimal and return
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}