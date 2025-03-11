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


public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Manufacturer { get; set; }
}

public class Food
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Manufacturer { get; set; }
}