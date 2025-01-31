using System;

class MaxOfThree
{
    static void Main()
    {
        int num1 = GetNumber("Enter first number: ");
        int num2 = GetNumber("Enter second number: ");
        int num3 = GetNumber("Enter third number: ");

        int max = FindMax(num1, num2, num3);
        Console.WriteLine("The maximum number is: " + max);
    }

    static int GetNumber(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine());
    }

    static int FindMax(int a, int b, int c)
    {
        int max = a;
        if (b > max)
            max = b;
        if (c > max)
            max = c;
        return max;
    }
}
