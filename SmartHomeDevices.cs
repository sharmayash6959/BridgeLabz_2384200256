using System;

// Base class: Device
class Device
{
    public int DeviceId { get; set; }
    public string Status { get; set; }

    public Device(int deviceId, string status)
    {
        DeviceId = deviceId;
        Status = status;
    }

    public virtual void DisplayStatus()
    {
        Console.WriteLine("Device ID: "+DeviceId+", Status: "+Status);
    }
}

// Subclass: Thermostat
class Thermostat : Device
{
    public double TemperatureSetting { get; set; }

    public Thermostat(int deviceId, string status, double temperatureSetting) : base(deviceId, status)
    {
        TemperatureSetting = temperatureSetting;
    }

    public override void DisplayStatus()
    {
        base.DisplayStatus();
        Console.WriteLine("Temperature Setting: "+TemperatureSetting+"°C");
    }
}

class SmartHomeDevices
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat(101, "Online", 22.5);
        thermostat.DisplayStatus();
    }
}
