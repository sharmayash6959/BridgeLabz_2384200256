using System;

class Program11
{
	public double calculateWindChill(double temp, double windSpeed)
	{
		double windChill = 35.74 + 0.6215 *temp + (0.4275*temp - 35.75) * windSpeed*0.16;
        return windChill;		
	}	
	public static void Main(string[] args)
	{
		Program11 obj = new Program11();
		
		Console.WriteLine("Enter temperature: ");
		double temp = Convert.ToDouble(Console.ReadLine()); 
		
		Console.WriteLine("Enter wind speed: ");
		double windSpeed = Convert.ToDouble(Console.ReadLine()); 
		
		double result = obj.calculateWindChill(temp, windSpeed);
		
		Console.WriteLine("Wind chill temperature is: "+result);
		
		
	
	}
}