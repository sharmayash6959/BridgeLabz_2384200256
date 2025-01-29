using System;

class Program1
{
	public double calculateSimpleInterest(double p, double r, double t)
	{
		double si = (p*r*t)/100;     //simple interest
		return si;
	}	
	public static void Main(string[] args)
	{
		Program1 obj = new Program1();   //object created
		
		Console.WriteLine("Enter principal: ");
		double p = Convert.ToDouble(Console.ReadLine()); //principal
		
		Console.WriteLine("Enter rate of interest: ");
		double r = Convert.ToDouble(Console.ReadLine()); //rate of interest percentage
		
		Console.WriteLine("Enter time: ");
		double t = Convert.ToDouble(Console.ReadLine()); //time period
		
		
		Console.WriteLine("The Simple Interest for Principal,"+p+" Rate of Interest "+r+" and Time "+t+" is "+obj.calculateSimpleInterest(p, r, t));
	}
}