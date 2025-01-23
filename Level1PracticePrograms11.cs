using System;

namespace Calculator{

class Level1PracticePrograms11
{
	static void Main(string[] args)
	{
		Console.Write("Enter number1: ");
		double num1 = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter number2: ");
		double num2 = Convert.ToDouble(Console.ReadLine());
		
		double add = num1 + num2;
		double subtract = num1 - num2;
		double multiply = num1 * num2;
		double divide = num1 / num2;
		
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "
		                  +num1+" and"+num2+" is "+add+","+subtract+","+multiply+",and "+divide);
		
	}
}
}