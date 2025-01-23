using System;

class Level1PracticePrograms5
{
	static void Main(string[] args)
	{
		int pens = 14;         //number of pens
		int students = 3;      //number of students
		
		int pensForEachStudent = pens / students;
		int pensRemainNonDistributed = pens % students;
		
		Console.WriteLine("The Pen Per Student is "+pensForEachStudent+ " and the remaining pen not distributed is "+pensRemainNonDistributed);
		
		
	}
}