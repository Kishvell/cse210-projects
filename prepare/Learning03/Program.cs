using System;

class <link>Program</link>
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        fraction1.SetNumerator(3);
        fraction1.SetDenominator(4);

        Console.WriteLine($"New Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction 4: {fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");
    }
}