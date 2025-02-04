using System;

class Vehicle
{
    // Instance Variables
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }

    // Class Variable
    private static double registrationFee = 500.00;

    // Constructor
    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    // Instance Method to Display Vehicle Details
    public void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner: "+OwnerName+", Vehicle Type: "+VehicleType+", Registration Fee: "+registrationFee);
    }

    // Class Method to Update Registration Fee
    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Problem9
{
    static void Main()
    {
        // Creating Vehicle Instances
        Vehicle vehicle1 = new Vehicle("Alice Smith", "Car");
        Vehicle vehicle2 = new Vehicle("Bob Johnson", "Motorcycle");
        
        // Displaying Vehicle Details
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
        
        // Updating Registration Fee
        Vehicle.UpdateRegistrationFee(600.00);
        
        // Displaying Vehicle Details After Update
        vehicle1.DisplayVehicleDetails();
        vehicle2.DisplayVehicleDetails();
    }
}
