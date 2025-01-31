using System;

class CountVowelsAndConsonants
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        int vowelCount = 0, consonantCount = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                char lowerCase = c;
                if (c >= 'A' && c <= 'Z')
                {
                    lowerCase = (char)(c + 32); // Convert to lowercase
                }
                
                if (lowerCase == 'a' || lowerCase == 'e' || lowerCase == 'i' || lowerCase == 'o' || lowerCase == 'u')
                    vowelCount++;
                else
                    consonantCount++;
            }
        }
        
        Console.WriteLine("Number of vowels: " + vowelCount);
        Console.WriteLine("Number of consonants: " + consonantCount);
    }
}
