using System;

class Program8
{
    // Method to find the smallest and largest numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));
        return new int[] { smallest, largest };
    }

    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Display the results
        Console.WriteLine("Smallest number: "+result[0]);
        Console.WriteLine("Largest number: "+result[1]);
    }
}
