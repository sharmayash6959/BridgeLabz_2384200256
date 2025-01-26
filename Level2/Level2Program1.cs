using System;

class Level2Program1
{
    static void Main()
    {
        // Arrays to store salary, years of service, bonus, and new salary
        double[] salary = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];

        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        // Loop to take input from the user for salary and years of service
        for (int i = 0; i < 10; i++)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.Write("Enter salary for employee "+(i + 1)+": ");
                string salaryInput = Console.ReadLine();
                Console.Write("Enter years of service for employee "+(i + 1)+": ");
                string yearsInput = Console.ReadLine();

                if (double.TryParse(salaryInput, out salary[i]) && salary[i] > 0 &&
                    double.TryParse(yearsInput, out yearsOfService[i]) && yearsOfService[i] >= 0)
                {
                    validInput = true;
                    totalOldSalary += salary[i]; // Add to total old salary
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter valid salary and years of service.");
                    i--; // Decrement index to allow re-entry
                }
            }
        }

        // Loop to calculate the bonus, new salary, and totals
        for (int i = 0; i < 10; i++)
        {
            if (yearsOfService[i] > 5)
            {
                bonus[i] = salary[i] * 0.05; // 5% bonus
            }
            else
            {
                bonus[i] = salary[i] * 0.02; // 2% bonus
            }

            newSalary[i] = salary[i] + bonus[i]; // Calculate new salary
            totalBonus += bonus[i]; // Add to total bonus
            totalNewSalary += newSalary[i]; // Add to total new salary
        }

        // Print the results
        Console.WriteLine("\nEmployee Bonus Details:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Employee "+(i + 1)+": Salary = "+salary[i]+", Years of Service = "+yearsOfService[i]+", Bonus = "+bonus[i]+", New Salary = "+newSalary[i]);
        }

        // Print the total bonus payout, total old salary, and total new salary
        Console.WriteLine("\nTotal Bonus Payout: "+totalBonus);
        Console.WriteLine("Total Old Salary: "+totalOldSalary);
        Console.WriteLine("Total New Salary: "+totalNewSalary);
    }
}
