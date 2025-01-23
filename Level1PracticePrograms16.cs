using System;

class Level1PracticePrograms16
{
	static void Main(string[] args)
	{   
	    Console.Write("Enter number of students: ");
		int numberOfStudents = Convert.ToInt32(Console.ReadLine());
		
		int numOfHandshakes = ((numberOfStudents*(numberOfStudents - 1))/2);   //number of possible handshakes
		
		Console.WriteLine("Number of possible handshakes: "+numOfHandshakes);
	}
}