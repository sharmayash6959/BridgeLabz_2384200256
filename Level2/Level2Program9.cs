using System;

class Level2Program9
{
    static void Main()
    {
        // Take input for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = int.Parse(Console.ReadLine());

        // Create a 2D array to store marks in Physics, Chemistry, and Maths for each student
        double[,] marks = new double[numStudents, 3]; // 3 subjects per student
        double[] percentages = new double[numStudents]; // Store percentages for each student
        string[] grades = new string[numStudents]; // Store grades for each student

        // Take input for marks of students in Physics, Chemistry, and Maths
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nStudent +"(i + 1)+":");

            // Input marks for Physics (ensure positive marks)
            double physicsMarks;
            do
            {
                Console.Write("Enter marks in Physics: ");
                physicsMarks = double.Parse(Console.ReadLine());
                if (physicsMarks < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Please enter positive marks.");
                }
            } while (physicsMarks < 0);

            // Input marks for Chemistry (ensure positive marks)
            double chemistryMarks;
            do
            {
                Console.Write("Enter marks in Chemistry: ");
                chemistryMarks = double.Parse(Console.ReadLine());
                if (chemistryMarks < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Please enter positive marks.");
                }
            } while (chemistryMarks < 0);

            // Input marks for Maths (ensure positive marks)
            double mathsMarks;
            do
            {
                Console.Write("Enter marks in Maths: ");
                mathsMarks = double.Parse(Console.ReadLine());
                if (mathsMarks < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Please enter positive marks.");
                }
            } while (mathsMarks < 0);

            // Store marks in the 2D array
            marks[i, 0] = physicsMarks; // Marks in Physics
            marks[i, 1] = chemistryMarks; // Marks in Chemistry
            marks[i, 2] = mathsMarks; // Marks in Maths
        }

        // Calculate percentage and grade for each student
        for (int i = 0; i < numStudents; i++)
        {
            double totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2]; // Sum of marks in all subjects
            percentages[i] = (totalMarks / 300) * 100; // Calculate percentage

            // Determine grade based on percentage
            if (percentages[i] >= 90)
            {
                grades[i] = "A+";
            }
            else if (percentages[i] >= 80)
            {
                grades[i] = "A";
            }
            else if (percentages[i] >= 70)
            {
                grades[i] = "B";
            }
            else if (percentages[i] >= 60)
            {
                grades[i] = "C";
            }
            else if (percentages[i] >= 50)
            {
                grades[i] = "D";
            }
            else
            {
                grades[i] = "F";
            }
        }

        // Display the results for each student
        Console.WriteLine("\nResults for each student:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine("\nStudent "+(i + 1)+":");
            Console.WriteLine("Marks in Physics: "+marks[i, 0]);
            Console.WriteLine("Marks in Chemistry: "+marks[i, 1]);
            Console.WriteLine("Marks in Maths: "+marks[i, 2]);
            Console.WriteLine("Percentage: "+percentages[i]+"%");
            Console.WriteLine("Grade: "+grades[i]);
        }
    }
}
