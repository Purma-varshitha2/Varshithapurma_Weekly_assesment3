using System;

class Program
{
    static void Main()
    {
      
        Button submitButton = new Button("Submit");

        submitButton.OnClick += () => Console.WriteLine("Submit action executed!");

        submitButton.Click();
    }
}

