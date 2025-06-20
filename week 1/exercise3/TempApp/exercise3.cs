using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; }
    public string Category { get; }
    public double Price { get; }

    public Product(string name, string category, double price)
    {
        Name = name.ToLower();
        Category = category.ToLower();
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Product Name: {Name}, Category: {Category}, Price: {Price}");
    }

    // For storing in HashSet
    public override bool Equals(object obj)
    {
        if (obj is Product other)
            return Name == other.Name && Category == other.Category && Price == other.Price;
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Category, Price);
    }
}

class Exercise3
{
    // List to store all Products
    static List<Product> products = new List<Product>();

    // Dictionary to map Categories to Products
    static Dictionary<string, HashSet<Product>> catMap = new Dictionary<string, HashSet<Product>>();

    public static void AddSampleProducts()
    {
        AddProduct(new Product("P1", "C1", 79999));
        AddProduct(new Product("P2", "C1", 59999));
        AddProduct(new Product("P3", "C2", 4999));
        AddProduct(new Product("P4", "C2", 2999));
        AddProduct(new Product("P5", "C3", 39999));
    }

    public static void AddProduct(Product p)
    {
        products.Add(p);
        if (!catMap.ContainsKey(p.Category))
        {
            catMap[p.Category] = new HashSet<Product>();
        }
        catMap[p.Category].Add(p);
    }

    public static void SearchByName(string name)
    {
        Console.WriteLine($"Search Products by Product Name: {name}");
        bool foundProd = false;

        foreach (var product in products)
        {
            if (product.Name.Contains(name.ToLower()))
            {
                product.Display();
                foundProd = true;
            }
        }

        if (!foundProd)
        {
            Console.WriteLine("Product not found");
        }
    }

    public static void SearchByCategory(string category)
    {
        Console.WriteLine($"Search Products for Category: {category}");
        if (catMap.TryGetValue(category.ToLower(), out var catProducts) && catProducts.Count > 0)
        {
            foreach (var product in catProducts)
            {
                product.Display();
            }
        }
        else
        {
            Console.WriteLine("No products found in this category.");
        }
    }

    static void Main(string[] args)
    {
        AddSampleProducts();

        while (true)
        {
            Console.WriteLine("E-Commerce Product Search");
            Console.WriteLine("1. Search by Product Name");
            Console.WriteLine("2. Search by Category");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Product Name (P1 to P5): ");
                    string name = Console.ReadLine();
                    SearchByName(name);
                    break;
                case 2:
                    Console.Write("Enter Category (C1 to C3): ");
                    string category = Console.ReadLine();
                    SearchByCategory(category);
                    break;
                case 0:
                    Console.WriteLine("Exiting the program. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
