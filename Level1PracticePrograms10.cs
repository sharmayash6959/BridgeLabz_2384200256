using System;

class Level1PracticePrograms10
{
	static void Main(string[] args)
	{   
	    Console.Write("Enter height in centimeters: ");
		double heightInCm  = Convert.ToDouble(Console.ReadLine()); //height in centimeters
		
		double heightInInch = (heightInCm *(1/2.54));
        double heightInFoot = (heightInInch*(1/12));	

        Console.WriteLine("Your height in cm is "+heightInCm+"while in feet is "+heightInFoot+" and inches is "+heightInInch);		
		
	}
}