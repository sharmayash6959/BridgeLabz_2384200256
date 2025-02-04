using System;

class Employee
{
    // Public Variable
    public int EmployeeID { get; set; }

    // Protected Variable
    protected string Department;

    // Private Variable
    private double Salary;

    // Constructor
    public Employee(int employeeID, string department, double salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    // Public Method to Modify Salary
    public void SetSalary(double newSalary)
    {
        if (newSalary >= 0)
        {
            Salary = newSalary;
        }
        else
        {
            Console.WriteLine("Invalid salary amount. Salary cannot be negative.");
        }
    }

    // Public Method to Get Salary
    public double GetSalary()
    {
        return Salary;
    }

    // Method to Display Employee Details
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee ID: "+EmployeeID+", Department: "+Department+", Salary: "+Salary);
    }
}

// Subclass Demonstrating Access to Public and Protected Members
class Manager : Employee
{
    public string Role { get; set; }

    // Constructor
    public Manager(int employeeID, string department, double salary, string role)
        : base(employeeID, department, salary)
    {
        Role = role;
    }

    // Method to Display Manager Details
    public void DisplayManagerDetails()
    {
        Console.WriteLine("Manager ID: "+EmployeeID+", Department: "+Department+", Role: "+Role);
    }
}

class Program
{
    static void Main()
    {
        // Creating Employee Object
        Employee emp1 = new Employee(101, "HR", 50000.00);
        emp1.DisplayEmployeeDetails();
        
        // Modifying Salary
        emp1.SetSalary(55000.00);
        Console.WriteLine("Updated Salary: "+emp1.GetSalary());

        // Creating Manager Object
        Manager mgr1 = new Manager(102, "IT", 75000.00, "Project Manager");
        mgr1.DisplayManagerDetails();
    }
}