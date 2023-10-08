using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address();
        myAddress.Index = "49000";
        myAddress.Country = "Україна";
        myAddress.City = "Дніпро";
        myAddress.Street = "Проспект Гагаріна";
        myAddress.House = "15";
        myAddress.Apartment = "12";
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Поштова адреса:");
        myAddress.DisplayAddress();
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ReadKey();
    }
}
