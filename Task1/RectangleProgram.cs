using System;

class Rectangle
{
    private double side1; // ���� ��� ����� ������� ������������
    private double side2; // ���� ��� ����� ������� ������������

    public Rectangle(double side1, double side2)
    {
        // ����������� ����� Rectangle, �������� ���� side1 � side2 ����������, ���������� � ����������
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
        // ����� ��� ���������� ����� ������������
        return side1 * side2;
    }

    public double PerimeterCalculator()
    {
        // ����� ��� ���������� ��������� ������������
        return 2 * (side1 + side2);
    }

    public double Area
    {
        // ���������� ��� ��������� ����� ������������
        get { return AreaCalculator(); }
    }

    public double Perimeter
    {
        // ���������� ��� ��������� ��������� ������������
        get { return PerimeterCalculator(); }
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("������ ������� ����� ������� ������������: ");
//        double side1 = double.Parse(Console.ReadLine());

//        Console.Write("������ ������� ����� ������� ������������: ");
//        double side2 = double.Parse(Console.ReadLine());

//        // ��������� ��'��� ����� Rectangle, ��������� � ����������� �������� �����
//        Rectangle rectangle = new Rectangle(side1, side2);

//        Console.WriteLine($"����� ������������: {rectangle.Area}");
//        Console.WriteLine($"�������� ������������: {rectangle.Perimeter}");
//    }
//}
