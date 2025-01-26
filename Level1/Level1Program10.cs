using System;

class Level1Program10
{
    static void Main()
    {
        // Get user input for the number
        Console.Write("Enter a positive integer: ");
        string input = Console.ReadLine();

        // Validate input and check if it's a positive integer
        if (!int.TryParse(input, out int number) || (number <= 0))
        {
            Console.WriteLine("Error: Please enter a positive integer.");
            return; // Exit the program
        }

        // Create a String array to save the results
        string[] results = new string[number + 1]; // Include the last number in the range

        // Loop from 1 to the given number and apply FizzBuzz logic
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString(); // Save the number itself
            }
        }

        // Loop through the results array and display the output
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Position "+i+" = "+results[i]);
        }
    }
}
