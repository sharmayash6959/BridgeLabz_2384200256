using System;

class Level1Program3
{
    static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a number to generate its multiplication table: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter an integer: ");
        }

        // Define an array to store the multiplication results
        int[] multiplicationTable = new int[10];

        // Populate the array with multiplication results
        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            multiplicationTable[i] = number * (i + 1);
        }

        // Display the multiplication table
        Console.WriteLine("\nMultiplication Table for {number}:");
        for (int i = 0; i < multiplicationTable.Length; i++)
        {
            Console.WriteLine(number+ " * "+(i + 1)+" = "+multiplicationTable[i]);
        }
    }
}
