using System;

class CheckAnagram
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();
        
        if (AreAnagrams(str1, str2))
            Console.WriteLine("The strings are anagrams.");
        else
            Console.WriteLine("The strings are not anagrams.");
    }
    
    static bool AreAnagrams(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;
        
        char[] arr1 = new char[str1.Length];
        char[] arr2 = new char[str2.Length];
        
        for (int i = 0; i < str1.Length; i++)
        {
            arr1[i] = str1[i];
            arr2[i] = str2[i];
        }
        
        for (int i = 0; i < arr1.Length - 1; i++)
        {
            for (int j = i + 1; j < arr1.Length; j++)
            {
                if (arr1[i] > arr1[j])
                {
                    char temp = arr1[i];
                    arr1[i] = arr1[j];
                    arr1[j] = temp;
                }
                if (arr2[i] > arr2[j])
                {
                    char temp = arr2[i];
                    arr2[i] = arr2[j];
                    arr2[j] = temp;
                }
            }
        }
        
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        
        return true;
    }
}
