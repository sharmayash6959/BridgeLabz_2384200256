using System;

class Book
{
	public string title{get; set;}
	public string author{get; set;}
	public double price{get; set;}
	
	public Book()                    //Default Constructor
	{
		title = "Unknown";
		author = "Unknown";
		price = 0.0;
	}
	
	public Book(string title, string author, double price)
	{
		this.title = title;
		this.author = author;
		this.price = price;
	}
	
	public void display()
	{
		Console.WriteLine("Title: "+title+"Author: "+author+"Price: "+price);
	}
}
class Problem1
{
	public static void Main(string[] args)
	{
		//Using Default Constructor
		Book book1 = new Book();
		book1.display();
		
		//Using Parameterised Constructor
		Book book2 = new Book(" Wings Of Fire ", " APJ Abdul Kalaam ", 1500.56);
		book2.display();
	}
}