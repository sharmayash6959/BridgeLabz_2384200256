using System;

class Program12
{
    
    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle from degrees to radians
        double radians = Math.PI * angle / 180.0;

        
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        
        return new double[] { sine, cosine, tangent };
    }

    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter an angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        
        double[] results = CalculateTrigonometricFunctions(angle);

        
        Console.WriteLine("Sine(angle°): "+results[0]);
        Console.WriteLine("Cosine(angle°): "+results[1]);
	Console.WriteLine("Tangent(angle°): "+results[2]);
    }
}
