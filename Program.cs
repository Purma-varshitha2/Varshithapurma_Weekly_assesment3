using System;

class Program
{
    static void Main()
    {
      
        Manager manager1 = new Manager("Vinny");
        Department dept1 = new Department("HR", manager1);

        Console.WriteLine("Original Department:");
        dept1.Display();


        Department shallowCopy = dept1.ShallowCopy();
        Console.WriteLine("\nAfter Shallow Copy:");
        shallowCopy.Display();

   
        shallowCopy.Manager.Name = "Ram";

        Console.WriteLine("\nAfter modifying Manager in Shallow Copy:");
        Console.WriteLine("Original Department:");
        dept1.Display();
        Console.WriteLine("Shallow Copy Department:");
        shallowCopy.Display();
        Department deepCopy = dept1.DeepCopy();
        Console.WriteLine("\nAfter Deep Copy:");
        deepCopy.Display();
        deepCopy.Manager.Name = "Suni";

        Console.WriteLine("\nAfter modifying Manager in Deep Copy:");
        Console.WriteLine("Original Department:");
        dept1.Display();
        Console.WriteLine("Deep Copy Department:");
        deepCopy.Display();
    }
}
