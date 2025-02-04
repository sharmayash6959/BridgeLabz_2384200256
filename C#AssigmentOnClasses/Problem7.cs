using System;

class Product
{
    // Instance Variables
    public string ProductName { get; set; }
    public double Price { get; set; }

    // Class Variable
    private static int totalProducts = 0;

    // Constructor
    public Product(string productName, double price)
    {
        ProductName = productName;
        Price = price;
        totalProducts++; // Increment total products count
    }

    // Instance Method
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product: "+ProductName+", Price: "+Price);
    }

    // Class Method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: "+totalProducts);
    }
}

class Problem7
{
    static void Main()
    {
        // Creating Product Instances
        Product product1 = new Product("Laptop", 1200.99);
        Product product2 = new Product("Smartphone", 699.49);
        
        // Displaying Product Details
        product1.DisplayProductDetails();
        product2.DisplayProductDetails();
        
        // Displaying Total Number of Products
        Product.DisplayTotalProducts();
    }
}