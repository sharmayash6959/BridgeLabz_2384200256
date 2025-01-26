using System;

class SumOfDigits
{
	public static void Main(string[] args)
	{   
	    Console.WriteLine("Enter a number: ");
		int num = Convert.ToInt32(Console.ReadLine());  //Input number
		
		int sum = 0;
        
		while(num !=0)
		{
			int digits = num % 10;                     //digits of the number entered
			
			sum = sum +digits;			               //sum of digits
			num = num / 10;
		}
		Console.WriteLine("Sum of digits of the number entered: "+sum);
	}
}