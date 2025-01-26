using System;

class ControlFlowLevel1PracticePrograms11
{
    public static void Main(string[] args)
    {
        int sum = 0; // Initialize sum

        Console.WriteLine("Enter numbers to calculate the sum. Enter 0 or a negative number to stop.");
        
        while (true)
        {
            Console.Write("Enter a number: ");
			int number = Convert.ToInt32(Console.ReadLine());
			
                if (number <= 0)
                {
					sum += number; // Add the number to the sum
                    break; // Exit the loop if the user enters 0 or a negative number
					
                }

                
               else
               {
                   Console.WriteLine("Invalid input. Please enter an integer.");
               }
        }

        Console.WriteLine("The total sum is: "+sum);
    }
}
