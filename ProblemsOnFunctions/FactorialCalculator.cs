using System;

class FactorialCalculator
{
    static void Main(string[] args)
    {
        int number = GetNumber("Enter a number to calculate its factorial: ");
        
        long result = Factorial(number);
        Console.WriteLine("Factorial of "+number+" is "+result);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Factorial(n - 1);
    }
}
