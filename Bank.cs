using System;

public class Bank
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    
    private static double InterestRate = 2.0; 

    public Bank(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

   
    public static void SetInterestRate(double newRate)
    {
        InterestRate = newRate;
    }

   
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance:C}, Interest Rate: {InterestRate}%");
    }
}
