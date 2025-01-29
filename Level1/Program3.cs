using System;

class Program3
{
    public int maxNumberOfHandShakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    public static void Main(string[] args)
    {
        Program2 obj = new Program2();
        
        Console.WriteLine("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine()); // numberOfStudents

        int handshakes = obj.maxNumberOfHandShakes(n);  // max num of handshakes

        Console.WriteLine("Maximum number of handshakes: " + handshakes);
    }
}
