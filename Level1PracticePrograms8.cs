using System;

class Level1PracticePrograms8
{
	static void Main(string[] args)
	{
		double km = Convert.ToDouble(Console.ReadLine());  //Enter distance in kilometers
		
		double miles = km*1.6;
		Console.WriteLine("The total miles is "+miles+"mile for the given "+km+"km");
		
	}
}