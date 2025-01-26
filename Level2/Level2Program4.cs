using System;

class Level2Program4
{
    static void Main()
    {
        // Declare and initialize variables
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Define initial max size of the array and the array to store digits
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Store the digits of the number in the array
        while (number != 0)
        {
            // If the index reaches the maxDigit, increase the size of the array
            if (index == maxDigit)
            {
                maxDigit += 10;  // Increase maxDigit size by 10
                int[] temp = new int[maxDigit];  // Create a new array of increased size

                // Copy elements from digits array to temp array
                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i];
                }

                // Assign temp array to digits array
                digits = temp;
            }

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
