using System;

class Program5
{
	public static int checkNum(int n)
	{
		if(n>0){
			return 1;
		}
		else if(n<0){
			return -1;
		}
		else{
			return 0;
		}
	}
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine(checkNum(n));
	}
}