using System;

class Figure
{
    public int X { get; }
    public int Y { get; }

    public Figure(int x, int y)
    {
        X = x;
        Y = y;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Фігура розташована в точці ({X}, {Y})");
    }
}

class Circle : Figure
{
    public double Radius { get; }

    public Circle(int x, int y, double radius) : base(x, y)
    {
        Radius = radius;
    }

    public override void Display()
    {
        Console.WriteLine($"Коло розташоване в точці ({X}, {Y}) з радіусом {Radius} см.");
    }
}

class Rectangle : Figure
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(int x, int y, double width, double height) : base(x, y)
    {
        Width = width;
        Height = height;
    }

    public override void Display()
    {
        Console.WriteLine($"Прямокутник розташований в точці ({X}, {Y}) з шириною {Width} см і висотою {Height} см.");
        Console.ReadKey();
    }
}