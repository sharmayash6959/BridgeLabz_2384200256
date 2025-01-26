using System;

class ControlFlowLevel1PracticePrograms14
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
        if (number >= 0)
        {
            int factorial = 1; // Initialize factorial to 1
            int i = 1; 
            
            while (i <= number)
            {
                factorial *= i; // Multiply factorial by i
                i++;            
            }

            Console.WriteLine("The factorial of "+number+" is "+factorial.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}
