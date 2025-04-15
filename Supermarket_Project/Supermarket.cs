using System.Text.Json;

namespace Supermarket_Project;

public class Supermarket
{
    List<Product> products = new();
    
    public void AddProduct()
    {
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
    }

    public void SaveToFile()
    {
        string jsonToSave = JsonSerializer.Serialize(products);
        File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json", jsonToSave);
    }

    public void LoadFromFile()
    {
        string jsonToLoad = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/products_db.json");
        products = JsonSerializer.Deserialize<List<Product>>(jsonToLoad);
    }
    
    public void ShowAllProducts()
    {
        foreach (var item in products)
        {
            item.Show();
        }
    }

    public void DeleteProduct()
    {
        for (int i = 0; i < products.Count; ++i)
            Console.WriteLine($"[{i}] Product: " + products[i].Name);

        Console.Write("Enter number to delete: ");
        int numToDelete = Convert.ToInt32(Console.ReadLine());

        if (numToDelete < 0 || numToDelete >= products.Count)
        {
            Console.WriteLine("Number out of range!");
            return;
        }
            
        products.RemoveAt(numToDelete);
        Console.WriteLine("Product deleted successfully!");
    }

    public void ShowProductById()
    {
        for (int i = 0; i < products.Count; ++i)
            Console.WriteLine($"[{i}] Product: " + products[i].Name);

        Console.Write("Enter number to show: ");
        int numToShow = Convert.ToInt32(Console.ReadLine());

        if (numToShow < 0 || numToShow >= products.Count)
        {
            Console.WriteLine("Number out of range!");
            return;
        }
        var itemToShow = products[numToShow];
            
        itemToShow.Show();
    }

    public void ShowProductByName()
    {
        Console.Write("Enter product name to find: ");
        string nameToFind = Console.ReadLine().Trim();
            
        var foundItem = products.Find(x => x.Name.Contains(nameToFind));

        if (foundItem == null)
        {
            Console.WriteLine("Product not found!");
            return;
        }
            
        foundItem.Show();
    }
}