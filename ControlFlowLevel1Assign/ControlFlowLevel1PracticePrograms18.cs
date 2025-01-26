using System;

class ControlFlowLevel1PracticePrograms18
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
            Console.WriteLine("Multiplication table for "+number+" from 6 to 9:");
            
            for (int i = 6; i <= 9; i++)
            {
			Console.WriteLine(number+" * "+i+" = " +(number*i));
            }
        
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid integer.");
        //}
    }
}
