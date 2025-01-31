using System;

class PalindromeStringCheck
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        bool isPalindrome = true;
        int length = 0;

        // Find the length of the string manually
        foreach (char c in input)
        {
            length++;
        }

        for (int i = 0; i < length / 2; i++)
        {
            if (input[i] != input[length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }
        
        if (isPalindrome)
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
}
