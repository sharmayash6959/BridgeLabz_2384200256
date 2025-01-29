using System;

class Program10
{
    
    public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
    {
        
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        return new int[] { chocolatesPerChild, remainingChocolates };
    }

    public static void Main(string[] args)
    {
        
        Console.WriteLine("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        if (numberOfChildren == 0)
        {
            Console.WriteLine("The number of children cannot be zero.");
        }
        else
        {
            
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            
            Console.WriteLine("Each child gets "+result[0]+" chocolates.");
            Console.WriteLine("Remaining chocolates: "+result[1]);
        }
    }
}
