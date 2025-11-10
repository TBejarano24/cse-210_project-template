using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing constructors:");
        Console.WriteLine("");

        Fraction defaultFraction = new();
        Fraction wholeFraction = new(6);
        Fraction trueFraction = new(6, 7);

        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(wholeFraction.GetFractionString());
        Console.WriteLine(trueFraction.GetFractionString());

        Console.WriteLine("");

        Console.WriteLine("Testing setters and getters:");
        Console.WriteLine("");

        Fraction additionalFraction = new();

        defaultFraction.SetTop(1);
        defaultFraction.SetBottom(1);

        wholeFraction.SetTop(5);
        wholeFraction.SetBottom(1);

        trueFraction.SetTop(3);
        trueFraction.SetBottom(4);

        additionalFraction.SetTop(1);
        additionalFraction.SetBottom(3);

        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine($"{defaultFraction.GetDecimalValue():F2}");

        Console.WriteLine(wholeFraction.GetFractionString());
        Console.WriteLine($"{wholeFraction.GetDecimalValue():F2}");

        Console.WriteLine(trueFraction.GetFractionString());
        Console.WriteLine($"{trueFraction.GetDecimalValue():F2}");

        Console.WriteLine(additionalFraction.GetFractionString());
        Console.WriteLine($"{additionalFraction.GetDecimalValue():F2}");
    }
}