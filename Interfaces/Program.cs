using System;

interface IMovable
{
    // An interface can contain method declarations without implementations
    void Move(); // only a declaration
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();       // prints "Car is moving"
        bicycle.Move();   // prints "Bicycle is moving"

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

