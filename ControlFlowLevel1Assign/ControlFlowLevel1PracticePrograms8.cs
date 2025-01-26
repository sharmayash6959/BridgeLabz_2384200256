using System;

class ControlFlowLevel1PracticePrograms8
{
	public static void Main(string[] args)
	{
		Console.Write("Enter a counter value: ");
		int counter = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Rocket launch is ready to be at the count of ");
		while(counter !=1)
		{
			
			Console.WriteLine(counter);
			counter--;
		}
	}
}