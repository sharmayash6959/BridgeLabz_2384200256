using System;

namespace PerimeterOfSquare
{
	class Level1PracticePrograms13
	{
		static void Main(string[] args)
		{
			Console.Write("Enter side of square: ");
			double side = Convert.ToDouble(Console.ReadLine());
			
			double perimeter = 4*side;
			
			Console.WriteLine("The length of the side is "+side+" whose perimeter is "+perimeter);
			
		}
	}
}