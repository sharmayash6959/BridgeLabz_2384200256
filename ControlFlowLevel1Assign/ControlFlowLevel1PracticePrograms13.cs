using System;

class ControlFlowLevel1PracticePrograms13
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
		int n = Convert.ToInt32(Console.ReadLine());
		
        if (n > 0)
        {
            //formula of sum
            int formulaSum = n * (n + 1) / 2;

            int loopSum = 0, i = 1;
            while (i <= n)
            {
                loopSum += i;
                i++;
            }


            Console.WriteLine("Sum using formula: "+formulaSum);
            Console.WriteLine("Sum using while loop: "+loopSum);

            // Verify if both results match
            if (formulaSum == loopSum)
            {
                Console.WriteLine("Both computations are correct and give the same result.");
            }
            else
            {
                Console.WriteLine("There is a mismatch between the results.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer (natural number).");
        }
    }
}
