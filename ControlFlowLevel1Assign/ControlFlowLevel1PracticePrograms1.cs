using System;

class ControlFlowLevel1PracticePrograms1
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a numbers: ");
		int num = Convert.ToInt32(Console.ReadLine());
		
		if(num % 5 ==0)
		{
			bool result = true;
			Console.WriteLine(" Is the number "+num+" divisible by 5? "+result);
		}
		
		else
		{
			bool result = false;
			Console.WriteLine(" Is the number "+num+" divisible by 5? "+result);
		}
		
	}
}