using System;

class Person
{
    // Declare fields for name, age, and weight
    public string name;
    public int age;
    public double weight;

    // Method to print the person's details
    public void PrintPerson()
    {
        // Print name, age, and weight
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Weight: " + weight + " kg");
    }
}

class PersonData
{
    static void Main(string[] args)
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Assign values to the fields
        person.name = "Kannan";
        person.age = 19;
        person.weight = 58;

        // Call the PrintPerson method to display the details
        person.PrintPerson();
    }
}
