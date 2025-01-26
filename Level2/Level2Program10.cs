using System;

class Level2Program10
{
    static void Main()
    {
        // Take input for the number
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());

        // Convert the number to a string to easily access each digit
        string numStr = number.ToString();

        // Create an array to store the frequency of each digit (0 to 9)
        int[] frequency = new int[10];

        // Loop through each character in the string representation of the number
        foreach (char digit in numStr)
        {
            // Convert the character to an integer digit and increment its frequency
            int digitValue = int.Parse(digit.ToString());
            frequency[digitValue]++;
        }

        // Display the frequency of each digit (0 to 9)
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit "+i+": "+frequency[i]);
            }
        }
    }
}
