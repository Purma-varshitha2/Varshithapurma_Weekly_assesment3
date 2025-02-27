using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Calling Add() with two integers
        Console.WriteLine("Sum of 5 and 10 : " + calc.Add(5, 10));

        // Calling Add() with three integers
        Console.WriteLine("Sum of 5, 10, and 15 : " + calc.Add(5, 10, 15));

        // Calling Add() with two double values
        Console.WriteLine("Sum of 5.5 and 2.5 : " + calc.Add(5.5, 2.5));
    }
}
