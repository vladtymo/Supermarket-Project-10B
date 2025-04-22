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
using Supermarket_Project;

Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. мови
Console.WriteLine("---------- Welcome to Supermarket ----------");

Console.WriteLine("\tMENU:");
Console.WriteLine("\t0. Exit");
Console.WriteLine("\t1. Add new product");
Console.WriteLine("\t2. Save to file");
Console.WriteLine("\t3. Load from file");
Console.WriteLine("\t4. Show all products");
Console.WriteLine("\t5. Delete product");
Console.WriteLine("\t6. Find product by id");
Console.WriteLine("\t7. Find product by name");
Console.WriteLine("\t8. Sell product");

Supermarket supermarket = new();

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
            supermarket.AddProduct();
            break;
        case 2:
            supermarket.SaveToFile();
            break;
        case 3:
            supermarket.LoadFromFile();
            break;
        case 4:
            supermarket.ShowAllProducts();
            break;
        case 5:
            supermarket.DeleteProduct();
            break;
        case 6:
            supermarket.ShowProductById();
            break;
        case 7:
            supermarket.ShowProductByName();
            break;
    }
}

// клас продукт харчування є похідним від Товару, отже він має всі властивості товару