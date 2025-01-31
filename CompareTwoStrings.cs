using System;

class CompareTwoStrings
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();
        
        int minLength = str1.Length < str2.Length ? str1.Length : str2.Length;
        
        for (int i = 0; i < minLength; i++)
        {
            if (str1[i] < str2[i])
            {
                Console.WriteLine(str1+" comes before "+str2+" in lexicographical order.");
                return;
            }
            else if (str1[i] > str2[i])
            {
                Console.WriteLine(str2+" comes before "+str1+" in lexicographical order.");
                return;
            }
        }
        
        if (str1.Length < str2.Length)
        {
            Console.WriteLine(str1+" comes before "+str2+" in lexicographical order.");
        }
        else if (str1.Length > str2.Length)
        {
		Console.WriteLine(str2+" comes before "+str1+" in lexicographical order.");
        }
        else
        {
            Console.WriteLine("Both strings are equal.");
        }
    }
}