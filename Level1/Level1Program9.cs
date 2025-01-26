using System;

class Level1Program9
{
    static void Main()
    {
        // Get user input for rows and columns
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        // Create a 2D array (Matrix) with the given rows and columns
        int[,] matrix = new int[rows, columns];

        // Get user input to fill the matrix
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Enter element at position ["+i+","+ j+"]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Create a 1D array to store the elements of the 2D array
        int[] array = new int[rows * columns];

        // Define an index variable for the 1D array
        int index = 0;

        // Copy elements of the 2D array to the 1D array using nested loops
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }

        // Display the 1D array
        Console.WriteLine("The elements of the 2D array in the 1D array are:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
