using System;

class NumberGuessingGame
{
    static void Main()
    {
        Console.WriteLine("Think of a number between 1 and 100.");
        int low = 1, high = 100;
        
        while (true)
        {
            int guess = (low + high) / 2;
            Console.WriteLine("Is it "+guess+"? (h = too high, l = too low, c = correct)");
            char response = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (response == 'c')
            {
                Console.WriteLine("I guessed it!");
                break;
            }
            else if (response == 'h')
                high = guess - 1;
            else if (response == 'l')
                low = guess + 1;
            else
                Console.WriteLine("Invalid input, try again.");
        }
    }
}
