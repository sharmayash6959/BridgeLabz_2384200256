using System;

class Level1Program4
{
    static void Main()
    {
        // Define an array of 10 elements of type double
        double[] numbers = new double[10];
        double total = 0.0; // Variable to store the total
        int index = 0; // Index for the array

        Console.WriteLine("Enter numbers (up to 10). Enter 0 or a negative number to stop:");

        // Infinite loop for user input
        while (true)
        {
            Console.Write("Enter number "+(index + 1)+": ");
            double input;

            // Validate input
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Invalid input. Please enter a number: ");
            }

            // Break if input is 0 or negative
            if (input <= 0)
            {
                break;
            }

            // Store input in the array and increment index
            numbers[index] = input;
            index++;

            // Break if the array is full
            if (index == 10)
            {
                break;
            }
        }

        // Calculate the total using a for loop
        Console.WriteLine("\nThe numbers you entered are:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        // Display the total
        Console.WriteLine("\nThe total sum of the numbers is: "+total);
    }
}
