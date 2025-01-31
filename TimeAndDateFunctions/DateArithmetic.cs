using System;

class DateArithmetic
{
    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());
        
        DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        modifiedDate = modifiedDate.AddDays(-21); // Subtracting 3 weeks
        
        Console.WriteLine("Original Date: " + inputDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Modified Date: " + modifiedDate.ToString("yyyy-MM-dd"));
    }
}
