﻿using System;

class Animal
{
    // This method can be overridden in derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}

class Program
{
    static void Main()
    {
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        genericAnimal.MakeSound(); // prints "Some generic sound"
        dog.MakeSound();           // prints "Bark"
        cat.MakeSound();           // prints "Meow"

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
