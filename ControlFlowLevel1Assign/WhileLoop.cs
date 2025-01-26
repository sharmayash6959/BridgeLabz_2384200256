using System;

class WhileLoop
{
	public static void Main(string[] args)
	{
		int counter = 0;
		
		while(counter < 5)
		{
			counter = counter + 1;
			Console.WriteLine("Counter = " + counter);
		}
	}
}