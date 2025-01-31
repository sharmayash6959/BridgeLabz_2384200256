using System;

class PrimeChecker
{
    static void Main()
    {
        int number = GetNumber("Enter a number to check if it's prime: ");
        
        if (IsPrime(number))
            Console.WriteLine(number+" is a prime number.");
        else
            Console.WriteLine(number+" is not a prime number.");
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}