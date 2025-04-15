public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Manufacturer { get; set; }

    public void Show()
    {
        Console.WriteLine("------- Product ---------");
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Category: {this.Category}");
        Console.WriteLine($"Price: {this.Price}");
        Console.WriteLine($"Quantity: {this.Quantity}");
        Console.WriteLine($"Manufacturer: {this.Manufacturer}");
    }
}