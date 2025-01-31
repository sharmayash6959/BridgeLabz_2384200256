using System;

class FibonacciGenerator
{
    static void Main()
    {
        int terms = GetNumber("Enter the number of terms for the Fibonacci sequence: ");
        GenerateFibonacci(terms);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static void GenerateFibonacci(int terms)
    {
        int first = 0, second = 1, next;
        
        Console.WriteLine("Fibonacci Sequence:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }
}
