using System;

class BreakContinue
{
	public static void Main(string[] args)
	{
		int i = 0;
		
		while(i<=10)
		{
			i++;
			if(i % 2 ==0) continue;    //Skip even numbers
			
			if(i % 7 ==0) break;      //Break the loop if counter is divisible by 7
			
			Console.WriteLine("i = "+i);
		}
			
	}
}