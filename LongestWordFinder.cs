using System;

class LongestWordFinder
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine() + " ";
        
        string longestWord = "";
        string currentWord = "";
        
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != ' ')
            {
                currentWord += input[i];
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }
        
        Console.WriteLine("Longest word: " + longestWord);
    }
}
