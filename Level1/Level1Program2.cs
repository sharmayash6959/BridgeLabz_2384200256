using System;

class Level1Program2
{
    static void Main()
    {
        // Define an integer array of 5 elements
        int[] numbers = new int[5];

        // Get user input to store in the array
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter number "+(i + 1)+": ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Invalid input. Please enter an integer: ");
            }
        }

        // Loop through the array to check each number
        Console.WriteLine("\nResults:");
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num+" is positive and even.");
                }
                else
                {
                    Console.WriteLine(num+" is positive and odd.");
                }
            }
            else if (num < 0)
            {
                Console.WriteLine(num+" is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        // Compare the first and last elements of the array
        if (numbers[0] > numbers[1])
        {
            Console.WriteLine("\nThe first element is greater than the last element.");
        }
        else if (numbers[0] < numbers[1])
        {
            Console.WriteLine("\nThe first element is less than the last element.");
        }
        else
        {
            Console.WriteLine("\nThe first and last elements are equal.");
        }
    }
}
