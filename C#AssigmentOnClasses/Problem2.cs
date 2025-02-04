using System;

class Circle
{
	public double radius{get; set;}
	
	//Default Constructor
	public Circle()
	{
		radius = 0.0;
	}
	
	//Parameterised Constructor
	public Circle(double radius)
	{
		this.radius = radius; 
	}
	
	public void printRadius()
	{
		Console.WriteLine("Radius: "+radius);
	}
}
class Problem2
{
	public static void Main(string[] args)
	{
		//Uisng Default Constructor
		Circle c1 = new Circle();
		c1.printRadius();
		
		//Using Parameterised Constructor
		Circle c2 = new Circle(7.0);
		c2.printRadius();
	}
}