/* 1. ------------------- Супермаркет
Створити ієрархію класів для продажу товарів Супермаркету
    Продукт(назва, термін споживання, категорія - молочні. хлібобулочні та ін., ціна, кількість)
    Товар (назва, категорія - побутова хімія, текстиль та ін., ціна, кількість)
Створити програму для роботи Супермаркету
    - Додавання продукту(товару) у базу(врахувати, що товар у базі може бути наявний або ні)
    - Збереження бази товарів(у файл)
    - Завантаження бази товарів з файлу
    - Перегляд продуктів(товарів), впорядкованих по категоріях
    - Пошук певного товару(продукту) з видачею інформації про товар(продукт)
    - Видалення певного товару(продукту) з бази
    - Продаж товару(з видачею чеку)
*/

Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. мови
Console.WriteLine("---------- Welcome to Supermarket ----------");

Console.WriteLine("\tMENU:");
Console.WriteLine("\t1. Add new product");
Console.WriteLine("\t2. Save to file");
Console.WriteLine("\t3. Load from file");
Console.WriteLine("\t4. Show all products");
Console.WriteLine("\t5. Delete product");
Console.WriteLine("\t6. Sell product");

Product product = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {
        case 1:
            Console.Write("Enter product name: ");
            product.Name = Console.ReadLine();
            Console.Write("Enter product category: ");
            product.Category = Console.ReadLine();
            Console.Write("Enter product price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter product quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter product manufacture: ");
            product.Manufacturer = Console.ReadLine();
            break;
        case 4:
            Console.WriteLine("------- Product ---------");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Category: {product.Category}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine($"Quantity: {product.Quantity}");
            Console.WriteLine($"Manufacturer: {product.Manufacturer}");
            break;
    }
}
public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Manufacturer { get; set; }
}

// клас продукт харчування є похідним від Товару, отже він має всі властивості товару
public class Food : Product
{
    public string ExpirationDate { get; set; }
    public string Ingredients { get; set; }
}
