using System;

class Program4
{
	public static double numberOfRounds(double a, double b, double c)
	{
		double p = a+b+c;                 // perimeter of triangle
		double d = 5;                     // distance to be covered
		
		return d/p;                       // number of rounds
	}
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter side1: ");
		double a = Convert.ToDouble(Console.ReadLine()); //side1
		
		Console.WriteLine("Enter rate of side2: ");
		double b = Convert.ToDouble(Console.ReadLine()); //side2
		
		Console.WriteLine("Enter side3: ");
		double c = Convert.ToDouble(Console.ReadLine()); //side3
		
		Console.WriteLine("The number of rounds user needs to do to complete 5km run: " +numberOfRounds(a, b, c));

	}
}