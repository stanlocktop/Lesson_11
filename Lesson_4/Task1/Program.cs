class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        // Створюємо об'єкти класу Коло та Прямокутник
        Circle circle = new Circle(5, 5, 3.5);
        Rectangle rectangle = new Rectangle(10, 10, 4.0, 6.0);

        // Виводимо інформацію про фігури
        circle.Display();
        rectangle.Display();
        Console.ReadKey();
    }
}