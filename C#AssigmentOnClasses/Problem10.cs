using System;

class Student
{
    // Public Variable
    public int RollNumber { get; set; }

    // Protected Variable
    protected string Name;

    // Private Variable
    private double CGPA;

    // Constructor
    public Student(int rollNumber, string name, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }

    // Public Method to Get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public Method to Set CGPA
    public void SetCGPA(double cgpa)
    {
        if (cgpa >= 0.0 && cgpa <= 10.0)
        {
            CGPA = cgpa;
        }
        else
        {
            Console.WriteLine("Invalid CGPA value. Please enter a value between 0.0 and 10.0.");
        }
    }

    // Method to Display Student Details
    public void DisplayDetails()
    {
        Console.WriteLine("Roll Number: "+RollNumber+", Name: "+Name+", CGPA: "+CGPA);
    }
}

// Subclass Demonstrating Protected Member Usage
class PostgraduateStudent : Student
{
    public string ResearchTopic { get; set; }

    // Constructor
    public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
        : base(rollNumber, name, cgpa)
    {
        ResearchTopic = researchTopic;
    }

    // Method to Display Postgraduate Student Details
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Roll Number: "+RollNumber+", Name: "+Name+", Research Topic: "+ResearchTopic+", CGPA: "+GetCGPA());
    }
}

class Problem10
{
    static void Main()
    {
        // Creating Student Object
        Student student1 = new Student(101, "Alice Johnson", 9.2);
        student1.DisplayDetails();
        
        // Modifying CGPA
        student1.SetCGPA(9.5);
        Console.WriteLine($"Updated CGPA: {student1.GetCGPA()}");

        // Creating Postgraduate Student Object
        PostgraduateStudent pgStudent = new PostgraduateStudent(102, "Bob Smith", 8.7, "Artificial Intelligence");
        pgStudent.DisplayPostgraduateDetails();
    }
}