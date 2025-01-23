using System;

class Level1PrcaticePrograms9
{
	static void Main(string[] args)
	{   
	    Console.Write("Enter student fee: ");
		double fee = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("University discount percentage: ");
		double discountPercent = Convert.ToDouble(Console.ReadLine());
		
		
		double discountFee = ((discountPercent * fee)/100);
		
		double finalFee = fee - discountFee;

        Console.WriteLine("The discount amount is INR "+discountFee+" and final discounted fee is INR "+finalFee);		
	}
}