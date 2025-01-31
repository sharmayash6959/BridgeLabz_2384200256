using System;

class PalindromeChecker
{
    static void Main()
    {
        string input = GetInput("Enter a word or phrase to check if it's a palindrome: ");
        
        if (IsPalindrome(input))
            Console.WriteLine("It is a palindrome.");
        else
            Console.WriteLine("It is not a palindrome.");
    }

    static string GetInput(string message)
    {
        Console.Write(message);
        return Console.ReadLine().ToLower().Replace(" ", "");
    }

    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
