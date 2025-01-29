using System;

class Program9
{
    
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        
        int quotient = number / divisor;
        int remainder = number % divisor;

        
        return new int[] { quotient, remainder };
    }

    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        
        if (divisor == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            
            int[] result = FindRemainderAndQuotient(number, divisor);

           
            Console.WriteLine("Quotient: "+result[0]);
            Console.WriteLine("Remainder: "+result[1]);
        }
    }
}
