using System;

class Program
{
    static void Main()
    {
        User admin = new Admin("Vinny");
        User customer = new Customer("Ram");
        admin.AccessControl(); 
        customer.AccessControl();
    }
}

