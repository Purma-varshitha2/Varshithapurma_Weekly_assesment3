using System;

class Program
{
    static void Main()
    {
        // Creating a Person reference for a Student
        Person student = new Student { Name = "Jay", Age = 20, Course = "Computer Science" };
        student.GetDetails(); // Calls overridden method in Student

        // Creating a Person reference for a Teacher
        Person teacher = new Teacher { Name = "Ram", Age = 45, Subject = "Mathematics" };
        teacher.GetDetails(); // Calls overridden method in Teacher
    }
}
