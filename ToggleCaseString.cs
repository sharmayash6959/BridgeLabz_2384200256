using System;

class ToggleCaseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        char[] toggledString = new char[input.Length];
        
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (c >= 'A' && c <= 'Z')
            {
                toggledString[i] = (char)(c + 32); // Convert to lowercase
            }
            else if (c >= 'a' && c <= 'z')
            {
                toggledString[i] = (char)(c - 32); // Convert to uppercase
            }
            else
            {
                toggledString[i] = c; // Keep non-alphabet characters unchanged
            }
        }
        
        Console.Write("Toggled string: ");
        for (int i = 0; i < toggledString.Length; i++)
        {
            Console.Write(toggledString[i]);
        }
        Console.WriteLine();
    }
}
