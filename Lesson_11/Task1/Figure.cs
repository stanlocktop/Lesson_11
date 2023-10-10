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
        Console.WriteLine($"Գ���� ����������� � ����� ({X}, {Y})");
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
        Console.WriteLine($"���� ����������� � ����� ({X}, {Y}) � ������� {Radius} ��.");
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
        Console.WriteLine($"����������� ������������ � ����� ({X}, {Y}) � ������� {Width} �� � ������� {Height} ��.");
        Console.ReadKey();
    }
}