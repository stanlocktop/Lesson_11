using System;

class Address
{
	private string index; // індекс
	private string country; // країна
	private string city; // місто 
	private string street; // вулиця
	private string house; // номер будинку
	private string apartment; // номер квартири

	public string Index
	{
		get { return index; }
		set { index = value; }
	}

	public string Country
	{
		get { return country; }
		set { country = value; }
	}

	public string City
	{
		get { return city; }
		set { city = value; }
	}

	public string Street
	{
		get { return street; }
		set { street = value; }
	}

	public string House
	{
		get { return house; }
		set { house = value; }
	}

	public string Apartment
	{
		get { return apartment; }
		set { apartment = value; }
	}

	public void DisplayAddress()
	{
		Console.OutputEncoding = System.Text.Encoding.Unicode;
		Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
		Console.WriteLine($"Індекс: {Index}");
		Console.WriteLine($"Країна: {Country}");
		Console.WriteLine($"Місто: {City}");
		Console.WriteLine($"Вулиця: {Street}");
		Console.WriteLine($"Номер будинку: {House}");
		Console.WriteLine($"Номер квартири: {Apartment}");
	}
}