using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class Fraction
{
    //Member Attributes
    private int _top;
    private int _bottom;


    //Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Methods
    // //Override ToString() method:
    // public override string ToString()
    // {
    //     return $"{_top}/{_bottom}";
    // }

 

    //Create Fractions
    public string GetFractionString()
    {
        string text = $"{_top} / {_bottom}";
        return text;
    }

    //Create Decimals
    public double GetDecimalValue()
    {
        double decimalValue = (double) _top / (double) _bottom;
        return decimalValue;
    }
}