class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Car car = new Car("Honda", 200, 4);
        Bicycle bicycle = new Bicycle("Дорожник", 30, "Україна");
        car.Display();
        bicycle.Display();
        Console.ReadKey();
    }
}





