using System;

class ControlFlowLevel1PracticePrograms3
{
	public static void Main(string[] args)
	{
		Console.Write("Enter first number: ");
		int num1 = Convert.ToInt32(Console.ReadLine());     //first number
		
		Console.Write("Enter second number: ");
		int num2 = Convert.ToInt32(Console.ReadLine());     //second number
		
		Console.Write("Enter third number: ");
		int num3 = Convert.ToInt32(Console.ReadLine());     //third number

                                                                                                           
			Console.WriteLine("Is the first number the largest? "+((num1 > num2) && (num1 > num3)));         //To check condition for first number
			Console.WriteLine("Is the second number the largest? "+((num2 > num1) && (num2 > num3)));        //To check condition for second number
			Console.WriteLine("Is the third number the largest? "+((num3 > num1) && (num3 > num2)));         //To check condition for third number
			
	}
}