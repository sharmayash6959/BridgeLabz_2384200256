using System;

class Level1PracticePrograms15
{
	static void Main(string[] args)
	{   
	    Console.Write("Enter unit price of an item: ");
		double unitPrice = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter the quantity to be bought: ");
		double quantity = Convert.ToDouble(Console.ReadLine());
		
		double totalPrice = quantity * unitPrice;
		
		Console.WriteLine("The total purchase price is INR "+totalPrice+ " if the quantity "+quantity+" and unit price is INR "+unitPrice);
	}
}