using System;

class Program
{
    static void Main(string[] args)
    {
        // Fraction instantiations
        Fraction paloPalito = new Fraction();
        Fraction paloPalito2 = new Fraction(5);
        Fraction paloPalito3 = new Fraction(5, 7);

        paloPalito3.SetTop(3);
        paloPalito3.SetBottom(4);

        Console.WriteLine(paloPalito.GetFractionString());
        Console.WriteLine(paloPalito.GetDecimalValue());
        Console.WriteLine(paloPalito2.GetFractionString());
        Console.WriteLine(paloPalito2.GetDecimalValue());
        Console.WriteLine(paloPalito3.GetFractionString());
        Console.WriteLine(paloPalito3.GetDecimalValue());

        paloPalito3.SetTop(1);
        paloPalito3.SetBottom(3);
        Console.WriteLine(paloPalito3.GetFractionString());
        Console.WriteLine(paloPalito3.GetDecimalValue());

        Console.WriteLine($"{paloPalito3.GetTop()}/{paloPalito3.GetBottom()}");

    }
}