using System;

class ControlFlowLevel1PracticePrograms17
{
	public static void Main(string[] args)
	{  
	    Console.Write("Enter salary of employee: ");
		double salary = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter years of service: ");            
		double yearsOfService = Convert.ToDouble(Console.ReadLine());  //years of services
		
		if(yearsOfService > 5)
		{
			double bonusPercent = 5;                     //bonus in percent
			
			double bonus = (bonusPercent * salary)/100 ;        //amount of bonus
			
			Console.WriteLine("Bonus amount is : "+bonus);
		}
		else
		{
			Console.WriteLine("No Bonus");
		}
		
	}
}