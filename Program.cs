using System;

class Program
{
    static void Main()
    {
        Bank acc1 = new Bank("Ajay", 10000);
        Bank acc2 = new Bank("Bunny", 15000);

        Console.WriteLine("Initial Interest Rate for All Accounts:");
        acc1.DisplayAccountDetails();
        acc2.DisplayAccountDetails();

        
        Bank.SetInterestRate(4.5);

        Console.WriteLine("\nAfter Changing Interest Rate:");
        acc1.DisplayAccountDetails();
        acc2.DisplayAccountDetails();
    }
}

