using System;

class ControlFlowLevel1PracticePrograms16
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
		int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0)
        {
            Console.WriteLine("Odd and Even numbers between 1 and "+number);

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i+" is an Even number.");
                }
                else
                {
                    Console.WriteLine(i+" is an Odd number.");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer (natural number).");
        }
    }
}
