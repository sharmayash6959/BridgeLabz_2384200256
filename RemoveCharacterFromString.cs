using System;

class RemoveCharacterFromString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        Console.Write("Enter the character to remove: ");
        char charToRemove = Console.ReadLine()[0];
        
        char[] result = new char[input.Length];
        int index = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != charToRemove)
            {
                result[index] = input[i];
                index++;
            }
        }
        
        Console.Write("Modified String: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}