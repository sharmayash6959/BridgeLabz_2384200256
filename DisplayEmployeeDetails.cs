using System;

class DisplayEmployeeDetails
{
    // Attributes
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // Constructor to initialize attributes
    public Employee(string name, int id, double salary)
    {
        this.Name = name;
        this.Id = id;
        this.Salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: $" + Salary);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an employee object
        Employee employee1 = new Employee("John Doe", 101, 50000.00);

        // Display the employee details
        employee1.DisplayDetails();
    }
}
