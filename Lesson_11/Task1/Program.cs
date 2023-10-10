class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Circle circle = new Circle(5, 5, 3.5);
        Rectangle rectangle = new Rectangle(10, 10, 4.0, 6.0);

        circle.Display();
        rectangle.Display();
        Console.ReadKey();
    }
}