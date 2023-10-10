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
        Console.WriteLine($"���������: {Name}, ����������� ��������: {MaxSpeed} ��/���");
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
        Console.WriteLine($"���������: {Name}, ����������� ��������: {MaxSpeed} ��/���, ʳ������ ������: {NumberOfDoors}");
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
        Console.WriteLine($"���������: {Name}, ����������� ��������: {MaxSpeed} ��/���, ��� ����������: {BicycleType}");
        Console.ReadKey();
    }
}
