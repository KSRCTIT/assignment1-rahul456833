using System;

class Patient
{
    // Data members to store patient information
    public string Name { get; set; }
    public DateTime DateOfAdmission { get; set; }
    public int Age { get; set; }
    public string Disease { get; set; }
    public DateTime DateOfDischarge { get; set; }
    public double TotalBillsPaid { get; set; }

    // Method to get patient details
    public void GetPatientInfo()
    {
        Console.Write("Enter patient name: ");
        Name = Console.ReadLine();

        Console.Write("Enter date of admission (yyyy-mm-dd): ");
        DateOfAdmission = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter age of patient: ");
        Age = int.Parse(Console.ReadLine());

        Console.Write("Enter disease: ");
        Disease = Console.ReadLine();

        Console.Write("Enter date of discharge (yyyy-mm-dd): ");
        DateOfDischarge = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter total bills paid: ");
        TotalBillsPaid = double.Parse(Console.ReadLine());
    }

    // Method to display patient details
    public void DisplayPatientInfo()
    {
        Console.WriteLine("\n--- Patient Details ---");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Date of Admission: {DateOfAdmission.ToShortDateString()}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Disease: {Disease}");
        Console.WriteLine($"Date of Discharge: {DateOfDischarge.ToShortDateString()}");
        Console.WriteLine($"Total Bills Paid: {TotalBillsPaid:C}");
    }
}

class Hospital
{
    static void Main(string[] args)
    {
        // Create an instance of the Patient class
        Patient patient = new Patient();

        // Call the method to get patient information
        patient.GetPatientInfo();

        // Call the method to display patient information
        patient.DisplayPatientInfo();
    }
}
