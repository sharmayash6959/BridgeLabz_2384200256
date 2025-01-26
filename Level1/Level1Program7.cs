using System;

class Level1Program7
{
    static void Main()
    {
        // Get input from the user
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        // Validate if the input is a natural number
        if (!int.TryParse(input, out int number) || number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number greater than 0.");
            return; // Exit the program
        }

        // Create arrays for odd and even numbers
        int[] evenNumbers = new int[number / 2 + 1]; // For even numbers
        int[] oddNumbers = new int[number / 2 + 1]; // For odd numbers

        // Initialize index variables for odd and even numbers
        int evenIndex = 0;
        int oddIndex = 0;

        // Loop through numbers from 1 to the entered number
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) // Check if the number is even
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else // The number is odd
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        // Print the odd numbers array
        Console.WriteLine("Odd numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        // Print the even numbers array
        Console.WriteLine("\nEven numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
