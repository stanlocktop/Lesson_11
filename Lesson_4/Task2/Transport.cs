using System;

// Базовий клас Транспорт
class Transport
{
    // Поля для назви транспортного засобу та максимальної швидкості
    public string Name { get; }
    public int MaxSpeed { get; }

    // Конструктор класу Транспорт
    public Transport(string name, int maxSpeed)
    {
        Name = name;
        MaxSpeed = maxSpeed;
    }

    // Метод для виведення інформації про транспортний засіб
    public virtual void Display()
    {
        Console.WriteLine($"Транспорт: {Name}, Максимальна швидкість: {MaxSpeed} км/год");
    }
}

// Похідний клас Автомобіль
class Car : Transport
{
    // Додаткове поле для кількості дверей
    public int NumberOfDoors { get; }

    // Конструктор класу Автомобіль
    public Car(string name, int maxSpeed, int numberOfDoors) : base(name, maxSpeed)
    {
        NumberOfDoors = numberOfDoors;
    }

    // Перевизначений метод для виведення інформації про автомобіль
    public override void Display()
    {
        Console.WriteLine($"Автомобіль: {Name}, Максимальна швидкість: {MaxSpeed} км/год, Кількість дверей: {NumberOfDoors}");
    }
}

// Похідний клас Велосипед
class Bicycle : Transport
{
    // Додаткове поле для типу велосипеда
    public string BicycleType { get; }

    // Конструктор класу Велосипед
    public Bicycle(string name, int maxSpeed, string bicycleType) : base(name, maxSpeed)
    {
        BicycleType = bicycleType;
    }

    // Перевизначений метод для виведення інформації про велосипед
    public override void Display()
    {
        Console.WriteLine($"Велосипед: {Name}, Максимальна швидкість: {MaxSpeed} км/год, Тип велосипеда: {BicycleType}");
        Console.ReadKey();
    }
}
