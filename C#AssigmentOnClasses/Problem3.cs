using System;

class Person
{
    
    public string Name { get; set; }
    public int Age { get; set; }

    // Default Constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Copy Constructor
    public Person(Person other)
    {
        Name = other.Name;
        Age = other.Age;
    }

    // Method to Display Person Details
    public void Display()
    {
        Console.WriteLine("Name: "+Name+", Age: "+Age);
    }
}

class Problem3
{
    static void Main()
    {
        // Using Parameterized Constructor
        Person person1 = new Person("John Doe", 30);
        person1.Display();

        // Using Copy Constructor
        Person person2 = new Person(person1);
        person2.Display();
    }
}
