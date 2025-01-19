using System;

namespace ExponentCalculator
{
	class Exponent
	{   
	    static int expo(int baseNum, int exponent)
		{
			if(exponent == 0)
			{
				return 1;
				
			}
			
			return baseNum * expo(baseNum, exponent - 1);
		}
		
		static void Main(string[] args)
		{
			Console.Write("Enter the base: ");
			int baseNum = int.Parse(Console.ReadLine());
			
			Console.Write("Enter the exponent: ");
			int exponent = int.Parse(Console.ReadLine());
			
			int result = expo(baseNum, exponent);
			
			Console.WriteLine($"{baseNum} raised to the power of {exponent} is {result}");
			
		}
	}
}