using System;

class Level2Program6
{
    static void Main()
    {
        // Get the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Declare arrays to store weight, height, BMI, and weight status
        double[] weights = new double[numPersons];
        double[] heights = new double[numPersons];
        double[] bmiValues = new double[numPersons];
        string[] weightStatus = new string[numPersons];

        // Take input for the weight and height of each person
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("\nPerson "+(i + 1)+":");

            Console.Write("Enter weight (in kg): ");
            weights[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter height (in meters): ");
            heights[i] = double.Parse(Console.ReadLine());

            // Calculate BMI
            bmiValues[i] = weights[i] / (heights[i] * heights[i]);

            // Determine weight status based on BMI
            if (bmiValues[i] < 18.5)
            {
                weightStatus[i] = "Underweight";
            }
            else if (bmiValues[i] >= 18.5 && bmiValues[i] < 24.9)
            {
                weightStatus[i] = "Normal weight";
            }
            else if (bmiValues[i] >= 25 && bmiValues[i] < 29.9)
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
            Console.WriteLine("\nPerson "+(i + 10)+":");
            Console.WriteLine("Height: "+heights[i]+" meters");
            Console.WriteLine("Weight: "+weights[i]+" kg");
            Console.WriteLine("BMI: "+bmiValues[i]);
            Console.WriteLine("Weight Status: "+weightStatus[i]);
        }
    }
}
