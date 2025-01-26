using System;

class ConditionalStatement
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter grade: ");
		
		int studentGrade = int.Parse(Console.ReadLine());
		
		if(studentGrade >= 50)
		{
			Console.WriteLine("Congratulations!");
			Console.WriteLine("You passed the examination");

		}
		else
		{
			Console.WriteLine("Sorry.");
			Console.WriteLine("You failed the examination");
		}
	}
}