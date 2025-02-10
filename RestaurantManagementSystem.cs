using System;

// Interface: Worker
interface Worker
{
    void PerformDuties();
}

// Base class: Person
class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

// Subclass: Chef
class Chef : Person, Worker
{
    public string Specialty { get; set; }

    public Chef(string name, int id, string specialty) 
        : base(name, id)
    {
        Specialty = specialty;
    }

    public void PerformDuties()
    {
        Console.WriteLine("Chef "+Name+" is preparing "+Specialty+" dishes.");
    }
}

// Subclass: Waiter
class Waiter : Person, Worker
{
    public int TablesAssigned { get; set; }

    public Waiter(string name, int id, int tablesAssigned) 
        : base(name, id)
    {
        TablesAssigned = tablesAssigned;
    }

    public void PerformDuties()
    {
        Console.WriteLine("Waiter "+Name+" is serving "+TablesAssigned+" tables.");
    }
}

class RestaurantManagementSystem
{
    static void Main()
    {
        Chef chef = new Chef("Gordon", 101, "Italian");
        Waiter waiter = new Waiter("John", 102, 5);

        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
