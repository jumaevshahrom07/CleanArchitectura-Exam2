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
        if (product.Name == null)
        {
            Console.WriteLine("Joi nomro kholi naguzored");
        }

        if (product.Price > 0)
        {
            Console.WriteLine("Shumo metavoned inro kharidori kuned");
        }
        if (product.Quantity >= 0)
        {
            product.Quantity++;
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
    }


    public void DeleteProduct(int id)
    {
        foreach (var item in products)
        {
            if (item.Id == id)
            {
                products.Remove(item);
                return;
            }
        }
    }


    public void IncreaseStock(int amount)
    {
        if (amount >= 0)
        {
            amount++;
        }
    }


    public void DecreaseStock(int amount)
    {
        if (amount > 0)
        {
            amount--;
        }
    }
}