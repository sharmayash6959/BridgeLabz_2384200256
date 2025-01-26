using System;


class ControlFlowSampleProgram1
{
	public static void Main(string[] args)
	{
		Console.Write("Enter first angle: ");
		double x = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter second angle: ");
		double y = Convert.ToDouble(Console.ReadLine());
		
		Console.Write("Enter third angle: ");
		double z = Convert.ToDouble(Console.ReadLine());
		
		double sumOfAngles = x+y+z;
		
		if(sumOfAngles == 180)
		{
			Console.WriteLine("The given angles "+x+","+y+","+z+" are internal angles of a triangle");
		}

        else
		{
			Console.WriteLine("The given angles are not angles of a triangle");
		}		
	}
}