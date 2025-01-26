using System;

class Level2Program7
{
    static void Main(string[] args)
    {
        // Take input for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Declare multi-dimensional array to store height, weight, and BMI for each person
        double[][] personData = new double[numPersons][3]; // Each row will store weight (index 0), height (index 1), and BMI (index 2)
        string[] weightStatus = new string[numPersons]; // Array to store weight status of each person

        // Take input for weight and height of each person
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("\nPerson "+(i + 1)+":");

            // Input weight (ensure it is positive)
            double weight;
            do
            {
                Console.Write("Enter weight (in kg): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0) 
                {
                    Console.WriteLine("Please enter a positive weight.");
                }
            } while (weight <= 0);

            // Input height (ensure it is positive)
            double height;
            do
            {
                Console.Write("Enter height (in meters): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0) 
                {
                    Console.WriteLine("Please enter a positive height.");
                }
            } while (height <= 0);

            // Store weight and height in personData array
            personData[i][0] = weight;
            personData[i][1] = height;

            // Calculate BMI
            double bmi = weight / (height * height);
            personData[i][2] = bmi;

            // Determine weight status based on BMI
            if (bmi < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                weightStatus[i] = "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                weightStatus[i] = "Overweight";
            }
            else
            {
                weightStatus[i] = "Obesity";
            }
        }

        // Display the results for each person
        Console.WriteLine("\nBMI and Weight Status for each person:");

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("\nPerson "+(i + 1)+":");
            Console.WriteLine("Height: "+personData[i][1]+" meters");
            Console.WriteLine("Weight: "+personData[i][0]+" kg");
            Console.WriteLine("BMI: "+personData[i][2]);
            Console.WriteLine("Weight Status: "+weightStatus[i]);
        }
    }
}
