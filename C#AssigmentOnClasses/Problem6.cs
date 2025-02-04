using System;

class CarRental
{
    
    public string CustomerName { get; set; }
    public string CarModel { get; set; }
    public int RentalDays { get; set; }
    public double DailyRate { get; set; }

    // Default Constructor
    public CarRental()
    {
        CustomerName = "Unknown";
        CarModel = "Standard";
        RentalDays = 1;
        DailyRate = 50.0; // Default rate per day
    }

    // Parameterized Constructor
    public CarRental(string customerName, string carModel, int rentalDays, double dailyRate = 50.0)
    {
        CustomerName = customerName;
        CarModel = carModel;
        RentalDays = rentalDays;
        DailyRate = dailyRate;
    }

    // Method to Calculate Total Cost
    public double CalculateTotalCost()
    {
        return RentalDays * DailyRate;
    }

    // Method to Display Rental Details
    public void Display()
    {
        Console.WriteLine("Customer: "+CustomerName+", Car Model: "+CarModel+", Rental Days: "+RentalDays+", Total Cost: "+CalculateTotalCost());
    }
}

class Problem6
{
    static void Main()
    {
        // Using Default Constructor
        CarRental rental1 = new CarRental();
        rental1.Display();

        // Using Parameterized Constructor
        CarRental rental2 = new CarRental("John Doe", "SUV", 5, 70.0);
        rental2.Display();
    }
}