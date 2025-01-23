using System;

class Level1PracticePrograms7
{
	static void Main(string[] args)
	{
		int r = 6378;           // radius of earth
		double volumeInKm = ((4/3)*3.14*r*r*r); // volume of Earth in cubic km
		double volumeInMiles = volumeInKm * 4.096;   //1 km^3 = 4.096miles^3
		
		Console.WriteLine("The volume of earth in cubic kilometers is "+volumeInKm+" and cubic miles is "+volumeInMiles );
		
	}
}