using System;

class RemoveDuplicates
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        char[] result = new char[input.Length];
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < index; j++)
            {
                if (input[i] == result[j])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                result[index] = input[i];
                index++;
            }
        }
        
        Console.Write("Modified string: ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
