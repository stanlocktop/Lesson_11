using System;

class Transport
{
    Console.OutputEncoding = System.Text.Encoding.Unicode;
    public string Name { get; }
    public int MaxSpeed { get; }

    public Transport(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Транспорт: {Name}, Максимальна швидкість: {MaxSpeed} км/год");
    }
}

class Car : Transport
{

    public int NumberOfDoors { get; }

    public Car(string name, int maxSpeed, int numberOfDoors) : base(name, maxSpeed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public override void Display()
    {
        Console.WriteLine($"Автомобіль: {Name}, Максимальна швидкість: {MaxSpeed} км/год, Кількість дверей: {NumberOfDoors}");
    }
}

class Bicycle : Transport
{
    public string BicycleType { get; }

    public Bicycle(string name, int maxSpeed, string bicycleType) : base(name, maxSpeed)
    {
        BicycleType = bicycleType;
    }
    public override void Display()
    {
        Console.WriteLine($"Велосипед: {Name}, Максимальна швидкість: {MaxSpeed} км/год, Тип велосипеда: {BicycleType}");
        Console.ReadKey();
    }
}
