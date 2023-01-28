using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fractions");

        Fraction fr1 = new Fraction();
        Console.WriteLine(fr1.GetFractionString());
        Console.WriteLine(fr1.GetDecimalValue());
        Console.WriteLine();

        Fraction fr2 = new Fraction(5);
        Console.WriteLine(fr2.GetFractionString());
        Console.WriteLine(fr2.GetDecimalValue());
        Console.WriteLine(fr2.GetTop());
        Console.WriteLine(fr2.GetBottom());
        Console.WriteLine();

        Fraction fr3 = new Fraction(3,4);
        Console.WriteLine(fr3); // prints Fraction
        Console.WriteLine(fr3.GetFractionString());
        Console.WriteLine(fr3.GetDecimalValue());
        Console.WriteLine(fr3.GetTop());
        Console.WriteLine(fr3.GetBottom());
        Console.WriteLine();

        Fraction fr4 = new Fraction(1,3);
        Console.WriteLine(fr4.GetFractionString());
        Console.WriteLine(fr4.GetDecimalValue());
        Console.WriteLine(fr4.GetTop());
        Console.WriteLine(fr4.GetBottom());
        Console.WriteLine();

        // Prints : 
        /*Fractions
        1/1
        1

        5/1
        5
        5
        1

        Fraction
        3/4
        0.75
        3
        4

        1/3
        0.3333333333333333
        1
        3*/
    }
}