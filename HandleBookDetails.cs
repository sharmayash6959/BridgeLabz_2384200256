using System;

class HandleBookDetails
{
    // Attributes
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Constructor to initialize attributes
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: $" + Price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Book object
        Book book1 = new Book("1984", "George Orwell", 9.99);

        // Display book details
        book1.DisplayDetails();
    }
}
