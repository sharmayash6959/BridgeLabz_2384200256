using System;

class MostFrequentCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        char mostFrequentChar = '\0';
        int maxCount = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            int count = 0;
            
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] == currentChar)
                {
                    count++;
                }
            }
            
            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentChar = currentChar;
            }
        }
        
        Console.WriteLine("Most frequent character: " + mostFrequentChar);
        Console.WriteLine("Frequency: " + maxCount);
    }
}