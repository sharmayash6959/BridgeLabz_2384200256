using System;

namespace KilometerToMilesConverter
{
	stati void Main(string[] args)
	{
		Console.Write("Enter distance in km: );
		double km = Console.ReadLine();
		
		double miles = km * 0.621371;
		
		Console.WriteLine($"{km} kms is equal to {miles} miles.");
	}
}