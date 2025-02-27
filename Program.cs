using System;

class Program
{
    static void Main()
    {
        
        ILogger fileLogger = new FileLogger();

        ILogger timestampLogger = new TimestampDecorator(fileLogger);

        
        ILogger errorLogger = new ErrorCategoryDecorator(timestampLogger, "ERROR");

      
        errorLogger.Log("An error occurred while processing the request.");
    }
}
