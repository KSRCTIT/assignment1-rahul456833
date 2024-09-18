using System;

class Employee
{
    // Data members for employee details
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public int JobCategory { get; set; }

    // Salary components
    private double BasicSalary;
    private double HRA;
    private double DA;
    private double PF;
    private double Loan;
    private double NetSalary;

    // Constructor to initialize based on job category
    public Employee(int jobCatg)
    {
        JobCategory = jobCatg;
        
        // Set values according to the job category (1 for Table-1, 2 for Table-2)
        if (JobCategory == 1)
        {
            BasicSalary = 8000;
            HRA = BasicSalary * 0.10;
            DA = BasicSalary * 0.20;
            Loan = 300;
            PF = 500;
        }
        else if (JobCategory == 2)
        {
            BasicSalary = 15000;
            HRA = BasicSalary * 0.20;
            DA = BasicSalary * 0.30;
            Loan = 600;
            PF = 1000;
        }
        else
        {
            Console.WriteLine("Invalid job category!");
        }
    }

    // Method to get input for employee details
    public void Input()
    {
        Console.Write("Enter Employee Number: ");
        EmpNo = int.Parse(Console.ReadLine());

        Console.Write("Enter Employee Name: ");
        EmpName = Console.ReadLine();
    }

    // Method to calculate the net salary
    public void CalculateSalary()
    {
        if (JobCategory == 1 || JobCategory == 2)
        {
            // Net salary formula: Basic + HRA + DA - PF - Loan
            NetSalary = BasicSalary + HRA + DA - PF - Loan;
        }
    }

    // Method to display the employee details and net salary
    public void Display()
    {
        Console.WriteLine("\n--- Employee Details ---");
        Console.WriteLine($"Employee No: {EmpNo}");
        Console.WriteLine($"Employee Name: {EmpName}");
        Console.WriteLine($"Job Category: {JobCategory}");

        Console.WriteLine("\n--- Salary Breakdown ---");
        Console.WriteLine($"Basic Salary: {BasicSalary:C}");
        Console.WriteLine($"HRA: {HRA:C}");
        Console.WriteLine($"DA: {DA:C}");
        Console.WriteLine($"PF: {PF:C}");
        Console.WriteLine($"Loan: {Loan:C}");
        Console.WriteLine($"Net Salary: {NetSalary:C}");
    }

    // Method to display the tables side by side
    public static void DisplaySalaryTables()
    {
        Console.WriteLine("\n--- Salary Tables ---");
        Console.WriteLine("{0,-25} {1,-25}", "Table 1 (Column 1)", "Table 2 (Column 2)");
        Console.WriteLine("{0,-25} {1,-25}", "---------------------", "---------------------");
        Console.WriteLine("{0,-25} {1,-25}", "BASIC: Rs. 8,000", "BASIC: Rs. 15,000");
        Console.WriteLine("{0,-25} {1,-25}", "HRA: 10% of basic", "HRA: 20% of basic");
        Console.WriteLine("{0,-25} {1,-25}", "DA: 20% of basic", "DA: 30% of basic");
        Console.WriteLine("{0,-25} {1,-25}", "LOAN: Rs. 300", "LOAN: Rs. 600");
        Console.WriteLine("{0,-25} {1,-25}", "PF: Rs. 500", "PF: Rs. 1,000");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Display salary tables side by side
        Employee.DisplaySalaryTables();

        // Get job category from the user
        Console.Write("\nEnter Job Category (1 for Table-1, 2 for Table-2): ");
        int jobCategory = int.Parse(Console.ReadLine());

        // Create an instance of the Employee class based on job category
        Employee employee = new Employee(jobCategory);

        // Input employee details
        employee.Input();

        // Calculate the salary
        employee.CalculateSalary();

        // Display employee details and net salary
        employee.Display();
    }
}
