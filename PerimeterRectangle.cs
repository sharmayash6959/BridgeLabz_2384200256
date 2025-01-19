using System;

class PerimeterRectangle
{
	static void Main()
	{
			Console.Write("Enter length: ");
	        double length = Convert.ToDouble(Console.ReadLine());
	
	        Console.Write("Enter width: ");
	        double width = Convert.ToDouble(Console.ReadLine());
	
	        double perimeter = 2*(length + width);
	
	        Console.WriteLine($"Perimeter of rectangle is: {perimeter}");
	}
		
}