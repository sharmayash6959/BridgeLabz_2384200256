using System;

// Superclass: Animal
class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual string MakeSound()
    {
        return "Animal makes a sound";
    }
}

// Subclass: Dog
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override string MakeSound()
    {
        return "Dog barks";
    }
}

// Subclass: Cat
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override string MakeSound()
    {
        return "Cat meows";
    }
}

// Subclass: Bird
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override string MakeSound()
    {
        return "Bird chirps";
    }
}

class AnimalHierarchy
{
    static void Main()
    {
        Animal[] animals = {
            new Dog("Buddy", 3),
            new Cat("Whiskers", 2),
            new Bird("Tweety", 1)
        };

        foreach (var animal in animals)
        {
		Console.WriteLine(animal.Name+" ("+animal.GetType().Name+"): "+animal.MakeSound());
        }
    }
}
