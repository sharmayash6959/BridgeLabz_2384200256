using System;

class Course
{
    // Instance Variables
    public string CourseName { get; set; }
    public int Duration { get; set; } // Duration in weeks
    public double Fee { get; set; }

    // Class Variable
    private static string instituteName = "Global Academy";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    // Instance Method to Display Course Details
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute: "+instituteName+", Course: "+CourseName+", Duration: "+Duration+" weeks, Fee: "+Fee);
    }

    // Class Method to Update Institute Name
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }
}

class Problem8
{
    static void Main()
    {
        // Creating Course Instances
        Course course1 = new Course("Data Science", 12, 1500.00);
        Course course2 = new Course("Web Development", 10, 1200.00);
        
        // Displaying Course Details
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
        
        // Updating Institute Name
        Course.UpdateInstituteName("Tech Innovators Academy");
        
        // Displaying Course Details After Update
        course1.DisplayCourseDetails();
        course2.DisplayCourseDetails();
    }
}