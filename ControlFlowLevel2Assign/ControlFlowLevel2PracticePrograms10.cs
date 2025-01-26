using System;

class ControlFlowLevel2PracticePrograms10
{
    static void Main(string[] args)
    {
        // Initialize variables
        double total = 0.0;
        double userInput;

        Console.WriteLine("Enter numbers to sum (enter 0 to stop):");

        // Start the loop
        while (true)
        {
            // Get input from the user
            Console.Write("Enter a number: ");
            if (!double.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            // Check if the user entered 0
            if (userInput == 0)
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
