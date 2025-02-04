using System;

class Book
{
    
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public bool IsAvailable { get; set; }

    // Default Constructor
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Price = 0.0;
        IsAvailable = true;
    }

    // Parameterized Constructor
    public Book(string title, string author, double price, bool isAvailable = true)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = isAvailable;
    }

    // Method to Borrow a Book
    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine("You have successfully borrowed '"+Title+"' by "+Author+".");
        }
        else
        {
            Console.WriteLine("Sorry, '"+Title+"' is currently not available.");
        }
    }

    // Method to Display Book Details
    public void Display()
    {
        Console.WriteLine("Title: "+Title+", Author: "+Author+", Price: "+Price+", Available: "+IsAvailable);
    }
}

class Problem5
{
    static void Main()
    {
        // Creating Books
        Book book1 = new Book("The Alchemist", "Paulo Coelho", 15.99);
        book1.Display();

        // Borrowing a Book
        book1.BorrowBook();
        book1.Display();

        // Attempt to Borrow Again
        book1.BorrowBook();
    }
}