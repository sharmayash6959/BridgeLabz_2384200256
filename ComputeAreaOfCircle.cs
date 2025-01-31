using System;

class ComputeAreaOfCircle
{
    // Attribute
    public double Radius { get; set; }

    // Constructor to initialize radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    // Method to display area and circumference
    public void DisplayDetails()
    {
        Console.WriteLine("Circle with radius: "+Radius);
        Console.WriteLine("Area: "+CalculateArea());
        Console.WriteLine("Circumference: "+CalculateCircumference());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Circle object
        Circle circle = new Circle(5.0);

        // Display area and circumference
        circle.DisplayDetails();
    }
}
