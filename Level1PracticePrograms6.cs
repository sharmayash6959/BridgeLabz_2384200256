using System;

class Level1PracticePrograms6
{
	static void Main(string[] args)
	{
		int fee = 125000;
		int discountPercent = 10;
		
		double discount = ((fee * discountPercent)/100);
		
		double finalFee = fee - discount;
		
		Console.WriteLine("The discount amount is INR "+discount+" and final discounted fee is INR "+finalFee);
	}
}