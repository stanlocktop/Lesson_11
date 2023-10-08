using System;

class Rectangle
{
    private double side1; // Поле для першої сторони прямокутника
    private double side2; // Поле для другої сторони прямокутника

    public Rectangle(double side1, double side2)
    {
        // Конструктор класу Rectangle, ініціалізує поля side1 і side2 значеннями, переданими в аргументах
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
        // Метод для обчислення площі прямокутника
        return side1 * side2;
    }

    public double PerimeterCalculator()
    {
        // Метод для обчислення периметра прямокутника
        return 2 * (side1 + side2);
    }

    public double Area
    {
        // Властивість для отримання площі прямокутника
        get { return AreaCalculator(); }
    }

    public double Perimeter
    {
        // Властивість для отримання периметра прямокутника
        get { return PerimeterCalculator(); }
    }
}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Введіть довжину першої сторони прямокутника: ");
//        double side1 = double.Parse(Console.ReadLine());

//        Console.Write("Введіть довжину другої сторони прямокутника: ");
//        double side2 = double.Parse(Console.ReadLine());

//        // Створюємо об'єкт класу Rectangle, передаючи в конструктор значення сторін
//        Rectangle rectangle = new Rectangle(side1, side2);

//        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
//        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
//    }
//}
