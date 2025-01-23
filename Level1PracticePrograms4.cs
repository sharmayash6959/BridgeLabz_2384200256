using System;

class Level1PracticePrograms4
{
	static void Main(string[] args)
	{
		double cp = 129; // cost price
		double sp = 191; // selling price
		
		double profit = sp - cp;
		
		double profitPercent = (profit/cp)*100;
		
		Console.WriteLine("The Cost Price is INR "+cp+" and Selling Price is INR "+sp);
		Console.WriteLine("The Profit is INR "+profit+" and the Profit Percentage is "+profitPercent);
		
	}
}