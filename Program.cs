using System;

class Program
{
    static void Main()
    {
        Report report = new Report
        {
            Title = "Monthly Sales Report",
            Content = "This report contains the sales data for the month."
        };

        // Using IPrintable interface
        IPrintable printableReport = report;
        printableReport.Print(); // Calls Print() method

        // Using ISerializable interface
        ISerializable serializableReport = report;
        serializableReport.SaveToFile("report.txt"); // Calls SaveToFile() method
    }
}
