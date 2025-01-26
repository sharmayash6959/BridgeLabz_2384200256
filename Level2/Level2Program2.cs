using System;

class Level2Program2
{
    static void Main()
    {
        // Arrays to store the ages and heights of the three friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Take user input for ages and heights
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter the age of friend "+(i + 1)+": ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of friend "+(i + 1)+" in meters: ");
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Find the youngest friend
        int youngestAge = ages[0];
        string youngestFriend = "Amar";
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestFriend = i == 1 ? "Akbar" : "Anthony";
            }
        }

        // Find the tallest friend
        double tallestHeight = heights[0];
        string tallestFriend = "Amar";
        for (int i = 1; i < 3; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = i == 1 ? "Akbar" : "Anthony";
            }
        }

        // Display the youngest and tallest friends
        Console.WriteLine("\nThe youngest friend is: "+youngestFriend+" ("+youngestAge+" years old)");
        Console.WriteLine("The tallest friend is: "+tallestFriend+" ("+tallestHeight+" meters tall)");
    }
}
