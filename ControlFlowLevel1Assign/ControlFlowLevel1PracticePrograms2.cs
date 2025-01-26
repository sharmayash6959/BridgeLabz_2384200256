using System;

class ControlFlowLevel1PracticePrograms1
{
	public static void Main(string[] args)
	{
		Console.Write("Enter number1: ");
		int num1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter number2: ");
		int num2 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Enter number3: ");
		int num3 = Convert.ToInt32(Console.ReadLine());
				
				
		bool isFirstSmall = num1 < num2 && num1 < num3;
		
		Console.WriteLine("Is the first number the smallest?"+isFirstSmall);
		
	}
}