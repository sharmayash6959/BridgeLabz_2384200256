using System;

class Level1PracticePrograms12
{
	static void Main(string[] args)
	{
		Console.Write("Enter base in inches : " );
		double baseInInches = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter height: ");
		double heightInInches = Convert.ToDouble(Console.ReadLine());
		
		double areaInInches = baseInInches * heightInInches;         //area in square inches
		double areaInCms = areaInInches * 2.54 * 2.54;               //area in square cms
		
		Console.WriteLine("Area of triangle in square inches is "+areaInInches+" while in square cm is "+areaInCms);
	}
}