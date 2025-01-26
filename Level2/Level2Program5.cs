using System;

class Level2Program5
{
    static void Main()
    {
        // Take user input for the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Count the number of digits in the number
        int temp = number;
        int count = 0;
        while (temp != 0)
        {
            temp /= 10;
            count++;
        }

        // Create an array to store the digits of the number
        int[] digits = new int[count];
        
        // Store the digits of the number in the array
        temp = number;
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        // Create an array to store the digits in reverse order
        int[] reverseDigits = new int[count];
        for (int i = 0; i < count; i++)
        {
            reverseDigits[i] = digits[count - 1 - i];
        }

        // Display the reversed array
        Console.Write("Reversed number is: ");
        foreach (int digit in reverseDigits)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}
