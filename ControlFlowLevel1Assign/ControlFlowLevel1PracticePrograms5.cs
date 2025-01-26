using System;

class ControlFlowLevel1PracticePrograms5
{
	public static void Main(string[] args)
	{   
	    Console.Write("Enter age: ");
		double age = Convert.ToDouble(Console.ReadLine());   //age in years
		
		//If the person is 18 or older, print "The person can vote." Otherwise, print "The person cannot vote."
		
		if(age >= 18)                        
		{
			Console.WriteLine("The person's age is "+age+" and can vote");
		}
		else
		{
			Console.WriteLine("The person's age is "+age+" and cannot vote");
		}
	}
}