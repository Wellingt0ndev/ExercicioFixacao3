using ExercicioFixacao3.Entities;
using System.Globalization;

List<Product> products = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for(int i = 1;  i <= n; i++)
{
    Console.WriteLine($"Product #{i} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if(ch == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        UsedProduct used = new UsedProduct(name,price,date);
        products.Add(used);
    } else if(ch == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        ImportedProduct imported = new ImportedProduct(name,price,customsFee);
        products.Add(imported);
    }
    else
    {
        Product product = new Product(name, price);
        products.Add(product);
    }

    
}

Console.WriteLine();
Console.WriteLine("Price Tags:");
foreach (Product product in products)
{
    Console.WriteLine(product.PriceTag());
}
