using System;

class DayOfWeek
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter a number between 1 to 7: ");
		int weekDayNumber = Convert.ToInt32(Console.ReadLine());
		
		switch(weekDayNumber)
		{
			case 1: Console.WriteLine("Monday");
			        break;
					
		    case 2: Console.WriteLine("Tuesday");
			        break;
					
			case 3: Console.WriteLine("Wednesday");
			        break;
					
		    case 4: Console.WriteLine("Thursday");
			        break;
					
			case 5: Console.WriteLine("Friday");
			        break;
			
			case 6: Console.WriteLine("Saturday");
			        break;
					
			case 7: Console.WriteLine("Sunday");
			        break;
					
			default : Console.WriteLine("Enter a valid day number");
                    break;			
		}
	}
}