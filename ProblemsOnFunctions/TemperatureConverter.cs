using System;

class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());
        
        Console.Write("Convert to Celsius or Fahrenheit? ");
        char choice = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        
        if (choice == 'C')
            Console.WriteLine(temp+" Fahrenheit is "+FahrenheitToCelsius(temp)+" Celsius");
        else if (choice == 'F')
            Console.WriteLine(temp+" Celsius is "+CelsiusToFahrenheit(temp)+" Fahrenheit");
        else
            Console.WriteLine("Invalid choice. Please enter 'C' or 'F'.");
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
