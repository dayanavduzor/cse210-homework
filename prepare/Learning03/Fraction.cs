//Fraccion class
using System;

public class Fraction
{
   private int  _top;
   private  int _bottom;

    public Fraction()
    {
        //default 1/1
        _top = 1;
        _bottom = 1;

    }
    public  Fraction(int wholenumber)
   {
        _top = wholenumber;
        _bottom = 1;
   }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public int GetTop() // getter or accesors
   {
        return _top; 
        
   }

    public void  SetTop(int topNumber)  // setter or mutators
   {
        _top = topNumber;
   }

    public int GetBottom()
   {
        return _bottom;
   }

    public void SetBottom( int bottom)
   {
        _bottom = bottom;
   }

   public string GetFractionString()
   {
        string fractionText = $"{_top}/{_bottom}";
        return fractionText;
   }

   public double GetDecimalValue()
   {
        return (double)_top / (double)_bottom;
   }
}