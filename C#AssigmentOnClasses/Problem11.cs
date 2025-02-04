using System;

class Book
{
    // Public Variable
    public string ISBN { get; set; }

    // Protected Variable
    protected string Title;

    // Private Variable
    private string Author;

    // Constructor
    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    // Public Method to Get Author Name
    public string GetAuthor()
    {
        return Author;
    }

    // Public Method to Set Author Name
    public void SetAuthor(string author)
    {
        Author = author;
    }

    // Method to Display Book Details
    public void DisplayDetails()
    {
        Console.WriteLine("ISBN: "+ISBN+", Title: "+Title+", Author: "+Author);
    }
}

// Subclass Demonstrating Access Modifiers
class EBook : Book
{
    public double FileSizeMB { get; set; }

    // Constructor
    public EBook(string isbn, string title, string author, double fileSize)
        : base(isbn, title, author)
    {
        FileSizeMB = fileSize;
    }

    // Method to Display EBook Details
    public void DisplayEBookDetails()
    {
        Console.WriteLine("ISBN: "+ISBN+", Title: "+Title+", File Size: "+FileSizeMB+" MB");
    }
}

class Problem11
{
    static void Main()
    {
        // Creating Book Object
        Book book1 = new Book("123-456-789", "The Great Gatsby", "F. Scott Fitzgerald");
        book1.DisplayDetails();
        
        // Modifying Author Name
        book1.SetAuthor("Francis Scott Fitzgerald");
        Console.WriteLine("Updated Author: "+book1.GetAuthor());

        // Creating EBook Object
        EBook ebook1 = new EBook("987-654-321", "Digital Fortress", "Dan Brown", 2.5);
        ebook1.DisplayEBookDetails();
    }
}