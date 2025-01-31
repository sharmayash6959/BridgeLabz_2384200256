using System;

class ReplaceWord
{
    static void Main(string[] args)
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        Console.Write("Enter the word to replace: ");
        string oldWord = Console.ReadLine();
        
        Console.Write("Enter the new word: ");
        string newWord = Console.ReadLine();
        
        string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified sentence: " + modifiedSentence);
    }
    
    static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        char[] result = new char[sentence.Length + newWord.Length - oldWord.Length];
        int i = 0, j = 0;
        
        while (i < sentence.Length)
        {
            bool match = true;
            for (int k = 0; k < oldWord.Length; k++)
            {
                if (i + k >= sentence.Length || sentence[i + k] != oldWord[k])
                {
                    match = false;
                    break;
                }
            }
            
            if (match)
            {
                for (int k = 0; k < newWord.Length; k++)
                {
                    result[j++] = newWord[k];
                }
                i += oldWord.Length;
            }
            else
            {
                result[j++] = sentence[i++];
            }
        }
        
        return new string(result, 0, j);
    }
}