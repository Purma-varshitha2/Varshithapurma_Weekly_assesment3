using System;
public class Student
{
    private string name;
    private int rollNo;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty.");
            }
            name = value;
        }
    }
    public int RollNo
    {
        get { return rollNo; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Roll number cannot be negative.");
            }
            rollNo = value;
        }
    }
    public Student(string name, int rollNo)
    {
        Name = name;
        RollNo = rollNo;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name:{Name},Roll No:{RollNo}");
    }
}