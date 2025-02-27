using System;

class Program
{
    static void Main()
    {
    
        ComplexNumber num1 = new ComplexNumber(1, 2);
        ComplexNumber num2 = new ComplexNumber(3, 4);

        ComplexNumber result = num1 + num2;

        Console.WriteLine($"First Complex Number: {num1}");
        Console.WriteLine($"Second Complex Number: {num2}");
        Console.WriteLine($"Sum: {result}");
    }
}
