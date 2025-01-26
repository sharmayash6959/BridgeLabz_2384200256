using System;

class ControlFlowLevel1PracticePrograms4
{
	public static void Main(string[] args)
	{
		Console.Write("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());  //Input a number
		
		if(num >=0)
		{
			Console.WriteLine("Natural Number");
		}
		else
		{
			Console.WriteLine("The number "+num+" is not a natural number");
		}
		
		Console.Write("Enter count of first natural numbers: ");
		int n = Convert.ToInt32(Console.ReadLine());   //first n natural numbers
		
		int sum = 0;
		
		sum = (n*(n+1))/2;
		
		Console.Write("The sum of first "+n+" natural numbers is "+sum);
		
	}
}