using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] reversed = new char[input.Length];
        int j = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed[j] = input[i];
            j++;
        }

        Console.Write("Reversed string: ");
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.Write(reversed[i]);
        }
        Console.WriteLine();
    }
}
