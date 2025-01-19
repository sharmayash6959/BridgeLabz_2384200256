using System;

class SimpleInterest
{
	static void Main(String[] args)
	{
		Console.Write("Enter Principal amount: ");
		double prin = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter rate of interest: ");
		double rate = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter time: ");
		double time = Convert.ToDouble(Console.ReadLine());
		
		double si = (prin * rate * time)/100;
		
		Console.WriteLine($"The Simple Interest is: {si}" );
	}
		
	
}