using System;

class Level2Program3
{
    static void Main()
    {
        // Declare and initialize variables
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        // Define an array to store the digits and max size of the array
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Store the digits of the number in the array
        while (number != 0)
        {
            if (index == maxDigit) break;  // Stop if the array size is reached
            
            digits[index] = number % 10;  // Get the last digit
            number /= 10;  // Remove the last digit
            index++;
        }

        // Variables to store largest and second largest digits
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        // Find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display the largest and second largest digit
        Console.WriteLine("The largest digit is: "+largest);
        Console.WriteLine("The second largest digit is: "+secondLargest);
    }
}
