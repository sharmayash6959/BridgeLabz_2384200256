using System;

namespace AverageCalculator
{
	class Average
	{
		static void Main(string[] args)
		{
			Console.Write("Enter first number: ");
			double num1 = Console.ReadLine();
			
			Console.Write("Enter second number: ");
			double num2 = Console.ReadLine();
			
			Console.Write("Enter third number: ");
			double num3 = Console.ReadLine();
			
			double average = (num1 + num2 + num3) / 3;
			
			Console.WtiteLine($"The average of {num1}, {num2} and {num3} is {average}");
		}
	}
}