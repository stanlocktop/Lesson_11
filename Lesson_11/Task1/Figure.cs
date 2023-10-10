using System;

// Базовий клас Фігура
class Figure
{
    // Поля для координат точки початку фігури (X та Y)
    public int X { get; }
    public int Y { get; }

    // Конструктор класу Фігура
    public Figure(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Метод для виведення інформації про фігуру
    public virtual void Display()
    {
        Console.WriteLine($"Фігура розташована в точці ({X}, {Y})");
    }
}

// Похідний клас Коло
class Circle : Figure
{
    // Додаткове поле для радіуса
    public double Radius { get; }

    // Конструктор класу Коло
    public Circle(int x, int y, double radius) : base(x, y)
    {
        Radius = radius;
    }

    // Перевизначений метод для виведення інформації про коло
    public override void Display()
    {
        Console.WriteLine($"Коло розташоване в точці ({X}, {Y}) з радіусом {Radius} см.");
    }
}

// Похідний клас Прямокутник
class Rectangle : Figure
{
    // Додаткові поля для ширини та висоти
    public double Width { get; }
    public double Height { get; }

    // Конструктор класу Прямокутник
    public Rectangle(int x, int y, double width, double height) : base(x, y)
    {
        Width = width;
        Height = height;
    }

    // Перевизначений метод для виведення інформації про прямокутник
    public override void Display()
    {
        Console.WriteLine($"Прямокутник розташований в точці ({X}, {Y}) з шириною {Width} см і висотою {Height} см.");
        Console.ReadKey();
    }
}