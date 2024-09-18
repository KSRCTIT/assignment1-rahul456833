using System;

class Student
{
    // Data members for student's basic details
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public string MobileNumber { get; set; }

    // Method to read student basic details
    public virtual void GetData()
    {
        Console.Write("Enter student name: ");
        Name = Console.ReadLine();

        Console.Write("Enter student age: ");
        Age = int.Parse(Console.ReadLine());

        Console.Write("Enter student address: ");
        Address = Console.ReadLine();

        Console.Write("Enter student mobile number: ");
        MobileNumber = Console.ReadLine();
    }

    // Method to print student basic details
    public virtual void PrintData()
    {
        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Mobile Number: {MobileNumber}");
    }
}

// Subclass inheriting from Student class
class StudentMark : Student
{
    // Data members for student's marks
    public double MathMark { get; set; }
    public double ScienceMark { get; set; }
    public double EnglishMark { get; set; }

    // Override GetData method to include marks input
    public override void GetData()
    {
        // Call base class GetData() to input basic details
        base.GetData();

        // Input marks
        Console.Write("Enter Math mark: ");
        MathMark = double.Parse(Console.ReadLine());

        Console.Write("Enter Science mark: ");
        ScienceMark = double.Parse(Console.ReadLine());

        Console.Write("Enter English mark: ");
        EnglishMark = double.Parse(Console.ReadLine());
    }

    // Override PrintData method to include marks output
    public override void PrintData()
    {
        // Call base class PrintData() to print basic details
        base.PrintData();

        // Print marks
        Console.WriteLine("\n--- Student Marks ---");
        Console.WriteLine($"Math Mark: {MathMark}");
        Console.WriteLine($"Science Mark: {ScienceMark}");
        Console.WriteLine($"English Mark: {EnglishMark}");

        // Print grade based on average marks
        FindGrade();
    }

    // Method to find and display the grade based on average marks
    public void FindGrade()
    {
        double averageMark = (MathMark + ScienceMark + EnglishMark) / 3;

        string grade;
        if (averageMark >= 90)
            grade = "A+";
        else if (averageMark >= 75)
            grade = "A";
        else if (averageMark >= 60)
            grade = "B";
        else if (averageMark >= 50)
            grade = "C";
        else
            grade = "Fail";

        Console.WriteLine($"Grade: {grade}");
    }
}

// Main class to access members of both Student and StudentMark classes
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the StudentMark class
        StudentMark student = new StudentMark();

        // Call methods to get and print student details and marks
        student.GetData();
        student.PrintData();
    }
}
