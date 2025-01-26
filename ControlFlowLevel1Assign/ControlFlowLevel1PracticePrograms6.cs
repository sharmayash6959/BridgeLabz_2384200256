using System;

class ControlFlowLevel1PracticePrograms6
{
	public static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		double num = Convert.ToDouble(Console.ReadLine());
		
		if(num > 0)                                //condition for positive number
		{
			Console.WriteLine("positive");
		} 
		else if(num < 0)                          //condition for negative number
		{
			Console.WriteLine("negative");
		}
		else                                     //condition for zero
		{
			Console.WriteLine("zero");
		}
		
		
	}
}