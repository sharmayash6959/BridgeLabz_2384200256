using System;

class Level1Program8
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Validate if the input is a valid number
        if (!int.TryParse(input, out int number) || number <= 0)
        {
            Console.WriteLine("Error: Please enter a valid positive integer.");
            return; // Exit the program
        }

        // Initialize variables
        int maxFactor = 10; // Initial capacity of the factors array
        int[] factors = new int[maxFactor]; // Array to store the factors
        int index = 0; // Index variable to track the position in the array

        // Loop through numbers from 1 to the given number to find the factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0) // Check if i is a factor of the number
            {
                // Add the factor to the array
                if (index == maxFactor) // Check if the array is full
                {
                    // Double the array size
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length); // Copy old values to the new array
                    factors = temp; // Assign the resized array back to the factors array
                }
                factors[index] = i;
                index++;
            }
        }

        // Display the factors
        Console.WriteLine("Factors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
