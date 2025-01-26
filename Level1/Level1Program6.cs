using System;

class Level1Program6
{
    static void Main()
    {
        // Define an array to store heights of 11 players
        double[] heights = new double[11];
        double sum = 0.0; // Variable to store the sum of heights

        Console.WriteLine("Enter the heights of 11 players (in cm):");

        // Get input values from the user
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write("Enter height of player "+(i + 1)+": ");
            while (!double.TryParse(Console.ReadLine(), out heights[i]) || heights[i] <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }
            sum += heights[i];
        }

        // Calculate the mean height
        double mean = sum / heights.Length;

        // Display the mean height
        Console.WriteLine("\nThe mean height of the football team is: "+mean+" cm");
    }
}
