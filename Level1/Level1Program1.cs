using System;

class Level1Program1
{
    static void Main()
    {
        // Define an array to store the ages of 10 students
        int[] ages = new int[10];

        // Take user input for the ages
        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter the age of student {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                ages[i] = age;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                i--; // Repeat the current iteration for valid input
            }
        }

        // Loop through the array and check voting eligibility
        foreach (int age in ages)
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age.");
            }
            else if (age >= 18)
            {
                Console.WriteLine($"The student with the age {age} can vote.");
            }
            else
            {
                Console.WriteLine($"The student with the age {age} cannot vote.");
            }
        }
    }
}
