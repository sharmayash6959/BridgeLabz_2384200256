using System;

class ControlFlowLevel2PracticePrograms11
{
    static void Main(string[] args)
    {
        // Initialize variables
        double total = 0.0;
        double userInput;

        Console.WriteLine("Enter numbers to sum (enter 0 or a negative number to stop):");

        // Start the infinite loop
        while (true)
        {
            // Get input from the user
            Console.Write("Enter a number: ");
            if (!double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Check if the user entered 0 or a negative number
            if (userInput <= 0)
            {
                break;
            }

            // Add the input to the total
            total += userInput;
        }

        // Display the total
        Console.WriteLine("The total sum is: "+total);
    }
}
