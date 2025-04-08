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

using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. мови
Console.WriteLine("---------- Welcome to Supermarket ----------");

Console.WriteLine("\tMENU:");
Console.WriteLine("\t0. Exit");
Console.WriteLine("\t1. Add new product");
Console.WriteLine("\t2. Save to file");
Console.WriteLine("\t3. Load from file");
Console.WriteLine("\t4. Show all products");
Console.WriteLine("\t5. Delete product");
Console.WriteLine("\t6. Sell product");

List<Product> products = new();

while (true)
{
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {
        case 0:
            Environment.Exit(0);
            break;
        case 1:
            var newItem = new Product();
            
            Console.Write("Enter product name: ");
            newItem.Name = Console.ReadLine();
            Console.Write("Enter product category: ");
            newItem.Category = Console.ReadLine();
            Console.Write("Enter product price: ");
            newItem.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter product quantity: ");
            newItem.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter product manufacture: ");
            newItem.Manufacturer = Console.ReadLine();
            
            products.Add(newItem);
            break;
        case 2:
            string jsonToSave = JsonSerializer.Serialize(products);
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json", jsonToSave);
            break;
        case 3:
            string jsonToLoad = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json");
            products = JsonSerializer.Deserialize<List<Product>>(jsonToLoad);
            break;
        case 4:
            foreach (var item in products)
            {
                Console.WriteLine("------- Product ---------");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Category: {item.Category}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Quantity: {item.Quantity}");
                Console.WriteLine($"Manufacturer: {item.Manufacturer}");
            }
            break;
        case 5:
            for (int i = 0; i < products.Count; ++i)
                Console.WriteLine($"[{i}] Product: " + products[i].Name);

            Console.Write("Enter number to delete: ");
            int numToDelete = Convert.ToInt32(Console.ReadLine());

            if (numToDelete < 0 || numToDelete >= products.Count)
            {
                Console.WriteLine("Number out of range!");
                break;
            }
            
            products.RemoveAt(numToDelete);
            Console.WriteLine("Product deleted successfully!");
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
