using Domain.Entities;

namespace Infrastructure.Services;

public class ProductServices
{
    private List<Product> products = new List<Product>();


    public List<Product> GetProducts()
    {
        return products;
    }


    public void CreateProduct(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name))
        {
            Console.WriteLine("Name is empty!");
            return;
        }

        if (product.Price <= 0)
        {
            Console.WriteLine("Price must be positive.");
            return;
        }

        if (product.Quantity <= 0)
        {
            Console.WriteLine("Quantity cannot be negative");
            return;
        }

        foreach (var item in products)
        {
            if (item.Id == product.Id)
            {
                Console.WriteLine("Duplicate Id!");
                return;
            }
        }
        products.Add(product);
    }


    public void UpdateProduct(int id, string name, decimal price, int quantity)
    {
        foreach (var item in products)
        {
            if (item.Id == id)
            {
                item.Name = name;
                item.Price = price;
                item.Quantity = quantity;
                return;
            }
        }
        Console.WriteLine("Product not found!");
    }


    public void DeleteProduct(int id)
    {
        bool isFound = false;
        foreach (var item in products)
        {
            if (item.Id == id)
            {
                products.Remove(item);
                isFound = true;
                return;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Product not found!");
        }
    }


    public void IncreaseStock(int id, int amount)
    {
        foreach (var item in products)
        {
            if (item.Id == id)
            {
                if (amount < 0)
                {
                    Console.WriteLine("Wrong amount");
                    return;
                }

                item.Quantity += amount;
                return;
            }
        }

        Console.WriteLine("Product not found!");
    }


    public void DecreaseStock(int id, int amount)
    {
        foreach (var item in products)
        {
            if (item.Id == id)
            {
                if (amount < 0 || item.Quantity - amount < 0)
                {
                    Console.WriteLine("Cannot decrease");
                    return;
                }

                item.Quantity -= amount;
                return;
            }
        }

        Console.WriteLine("Product not found!");
    }
}