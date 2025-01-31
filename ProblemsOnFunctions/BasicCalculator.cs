using System;

class BasicCalculator
{
    static void Main()
    {
        double num1 = GetNumber("Enter first number: ");
        double num2 = GetNumber("Enter second number: ");
        
        Console.Write("Choose operation (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        double result = PerformOperation(num1, num2, op);
        Console.WriteLine("Result: " + result);
    }

    static double GetNumber(string message)
    {
        Console.Write(message);
        return double.Parse(Console.ReadLine());
    }

    static double PerformOperation(double num1, double num2, char op)
    {
        switch (op)
        {
            case '+': return Add(num1, num2);
            case '-': return Subtract(num1, num2);
            case '*': return Multiply(num1, num2);
            case '/': return num2 != 0 ? Divide(num1, num2) : throw new DivideByZeroException("Error: Division by zero.");
            default: throw new ArgumentException("Invalid operation.");
        }
    }

    static double Add(double a, double b);
    static double Subtract(double a, double b);
    static double Multiply(double a, double b);
    static double Divide(double a, double b);
}
