using System;

namespace DistanceConverter
{
	class Level1PracticePrograms14
	{
		static void Main(string[] args)
		{
			Console.Write("Enter distance in feet: ");
			double distanceInFeet = Convert.ToDouble(Console.ReadLine());
			
			double distanceInYards = distanceInFeet / 3; // 1 yard = 3ft
			double distanceInMiles = distanceInYards / 1;  // 1 mile = 1760 yards
			
			Console.WriteLine("Distance in feet is "+distanceInFeet+" while in yards is "+distanceInYards+" and in miles is "+distanceInMiles);
			
		}
	}
}
