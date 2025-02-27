using System;

class Program
{
    static void Main()
    {
      
        NotificationService notificationService = new NotificationService();

       
        INotificationObserver emailObserver = new EmailNotifier("varshithapurma@gmail.com");
        INotificationObserver smsObserver = new SMSNotifier("+9763647278");

      
        notificationService.Subscribe(emailObserver);
        notificationService.Subscribe(smsObserver);

        
        Console.WriteLine("Sending notification...");
        notificationService.NotifyAll("Your order has been shipped!");

        
        notificationService.Unsubscribe(smsObserver);
        Console.WriteLine("\nSending another notification...");
        notificationService.NotifyAll("New promotional offer available!");
    }
}
