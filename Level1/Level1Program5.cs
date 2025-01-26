using System;

class Level1Program5
{
    static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a number to generate its multiplication table from 6 to 9: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter an integer: ");
        }

        // Define an array to store the multiplication results
        int[] multiplicationResult = new int[4]; // For 6, 7, 8, 9

        // Populate the array with multiplication results
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }

        // Display the multiplication table
        Console.WriteLine("\nMultiplication Table for "+number+" (from 6 to 9):");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number+" * "+i+" = "+multiplicationResult[i - 6]);
        }
    }
}
