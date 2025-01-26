using System;

class ControlFlowLevel1PracticePrograms7
{
    static void Main(string[] args)
    {
        // Check if correct number of arguments are provided
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide both month and day as command-line arguments.");
            return;
        }

        // Parse input arguments
        if (!int.TryParse(args[0], out int month) || !int.TryParse(args[1], out int day))
        {
            Console.WriteLine("Please enter valid integers for month and day.");
            return;
        }

        // Check if the date is within the Spring season
        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }

    static bool IsSpringSeason(int month, int day)
    {
        // Spring season is from March 20 to June 20
        if ((month == 3 && day >= 20 && day <= 31) || // March 20-31
            (month == 4 && day >= 1 && day <= 30) ||  // April
            (month == 5 && day >= 1 && day <= 31) ||  // May
            (month == 6 && day >= 1 && day <= 20))    // June 1-20
        {
            return true;
        }
        return false;
    }
}
