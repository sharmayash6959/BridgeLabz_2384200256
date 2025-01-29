using System;

class Program6
{
	public static string printSeason(int month, int day)
	{
		if((month == 3 && day>=20 || day <=31) ||          // march
		   (month == 4 && day>=1 || day <=30) ||           // april
		   (month == 5 && day>=1 || day <=31) ||           // may
		   (month == 3 && day>=1 || day <=30))             // june
		   {
			   
			    return "Its a Spring Season";
		   }             
	
		   else
		{
			return "Not a Spring Season";
		}  
	}
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter month: ");              //month number from 3 to 6
		int month = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter day: ");
		int day = Convert.ToInt32(Console.ReadLine());
		
		string result = printSeason(month, day);
		
		Console.WriteLine(result);
	}
}