using System;

// Interface: Refuelable
interface Refuelable
{
    void Refuel();
}

// Base class: Vehicle
class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    public Vehicle(int maxSpeed, string model)
    {
        MaxSpeed = maxSpeed;
        Model = model;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle Model: "+Model+", Max Speed: "+MaxSpeed+"km/h");
    }
}

// Subclass: ElectricVehicle
class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; } // in kWh

    public ElectricVehicle(int maxSpeed, string model, int batteryCapacity) 
        : base(maxSpeed, model)
    {
        BatteryCapacity = batteryCapacity;
    }

    public void Charge()
    {
        Console.WriteLine("Charging "+Model+" with "+BatteryCapacity+"kWh battery.");
    }
}

// Subclass: PetrolVehicle implementing Refuelable
class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelTankCapacity { get; set; } // in liters

    public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity) 
        : base(maxSpeed, model)
    {
        FuelTankCapacity = fuelTankCapacity;
    }

    public void Refuel()
    {
        Console.WriteLine("Refueling "+Model+" with "+FuelTankCapacity+" liters of petrol.");
    }
}

class VehicleManagementSystemUsingHybridInheritance
{
    static void Main()
    {
        ElectricVehicle tesla = new ElectricVehicle(200, "Tesla Model 3", 75);
        PetrolVehicle ford = new PetrolVehicle(180, "Ford Mustang", 60);

        tesla.DisplayInfo();
        tesla.Charge();

        ford.DisplayInfo();
        ford.Refuel();
    }
}
