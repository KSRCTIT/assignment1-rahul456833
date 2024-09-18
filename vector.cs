using System;

class Vector
{
    // Data members to store the vector components
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor to initialize vector components
    public Vector(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Overload the '+' operator for vector addition
    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    // Method to display the vector
    public void Display()
    {
        Console.WriteLine($"Vector: ({X}, {Y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get first vector input from the user
        Console.Write("Enter X component of first vector: ");
        int x1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Y component of first vector: ");
        int y1 = int.Parse(Console.ReadLine());

        // Get second vector input from the user
        Console.Write("Enter X component of second vector: ");
        int x2 = int.Parse(Console.ReadLine());
        Console.Write("Enter Y component of second vector: ");
        int y2 = int.Parse(Console.ReadLine());

        // Create two vector objects
        Vector v1 = new Vector(x1, y1);
        Vector v2 = new Vector(x2, y2);

        // Add vectors using overloaded '+' operator
        Vector sum = v1 + v2;

        // Display the result
        Console.WriteLine("\nThe sum of the two vectors is:");
        sum.Display();
    }
}
