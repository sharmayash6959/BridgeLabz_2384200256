using System;

class CountSubstringOccurences
{
    static void Main()
    {
        Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();
        
        Console.Write("Enter the substring to count: ");
        string subString = Console.ReadLine();
        
        int count = 0;
        int mainLength = 0, subLength = 0;

        foreach (char c in mainString)
        {
            mainLength++;
        }

        foreach (char c in subString)
        {
            subLength++;
        }

        for (int i = 0; i <= mainLength - subLength; i++)
        {
            bool match = true;
            for (int j = 0; j < subLength; j++)
            {
                if (mainString[i + j] != subString[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                count++;
            }
        }
        
        Console.WriteLine("Substring occurs " + count + " times.");
    }
}
