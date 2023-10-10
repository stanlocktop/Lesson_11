class Program
{
    static void Main(string[] args)
    {
        // Створюємо об'єкти класу Автомобіль та Велосипед
        Car car = new Car("Toyota", 200, 4);
        Bicycle bicycle = new Bicycle("BMX", 30, "Гірський");

        // Виводимо інформацію про транспортні засоби
        car.Display();
        bicycle.Display();
        Console.ReadKey();
    }
}





