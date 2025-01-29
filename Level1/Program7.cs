using System;

class Program7
{
	public int sumNaturalNumbers(int n)
	{
		int sum = 0;
		for(int i=1; i<=n; i++)
		{
			sum += i;               // sum of first n natural numbers
		}
		
		return sum;
	}
	public static void Main(string[] args)
	{
		Program7 obj = new  Program7();
		
		Console.WriteLine("Enter number of first natural numbers: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Sum of first "+n+" natural numbers is "+obj.sumNaturalNumbers(n));
		
	}
}