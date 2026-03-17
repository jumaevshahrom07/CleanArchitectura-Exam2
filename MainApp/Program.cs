using Domain;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Services;

ProductServices productServices = new ProductServices();
Product product1 = new Product()
{
    Id = 1,
    Name = "Iphone",
    Price = 15000.0m,
    Quantity = 1
};
Product product2 = new Product()
{
    Id = 2,
    Name = "MackBook",
    Price = 20000.0m,
    Quantity = 2
};
Product product3 = new Product()
{
    Id = 3,
    Name = "TV",
    Price = 10000.0m,
    Quantity = 2
};

productServices.CreateProduct(product1);
productServices.CreateProduct(product2);
productServices.CreateProduct(product3);

foreach (var item in productServices.GetProducts())
{
    Console.WriteLine();
    Console.WriteLine($"Id {item.Id}\nName {item.Name}\nPrice {item.Price}\nQuantity {item.Quantity}");
    Console.WriteLine();
    Console.WriteLine();
}

productServices.UpdateProduct(3, "Condition", 5000, 1);
foreach (var item in productServices.GetProducts())
{
    Console.WriteLine($"Id {item.Id}\nName {item.Name}\nPrice {item.Price}\nQuantity {item.Quantity}");
    Console.WriteLine();
    Console.WriteLine();
}

productServices.DeleteProduct(2);
foreach (var item in productServices.GetProducts())
{
    Console.WriteLine($"Id {item.Id}\nName {item.Name}\nPrice {item.Price}\nQuantity {item.Quantity}");
    Console.WriteLine();
    Console.WriteLine();
}

productServices.IncreaseStock(5);
productServices.DecreaseStock(10);


// using Domain;
// using Domain.Entities;
// using Infrastructure;
// using Infrastructure.Services;

// SupplierServices supplierServices = new SupplierServices();
// Supplier supplier1 = new Supplier()
// {
//     Id = 1,
//     Name = "Sharom",
//     Email = "shahromdzumaev61@gmail.com",
//     Phone = "048400400"
// };
// Supplier supplier2 = new Supplier()
// {
//     Id = 2,
//     Name = "Akbar",
//     Email = "akbardzumaev16@gmail.com",
//     Phone = "077616336"
// };
// Supplier supplier3 = new Supplier()
// {
//     Id = 3,
//     Name = "Abdullo",
//     Email = "abdullodzumaev13@gmail.com",
//     Phone = "937763497"
// };

// supplierServices.CreateSupplier(supplier1);
// supplierServices.CreateSupplier(supplier2);
// supplierServices.CreateSupplier(supplier3);

// foreach (var item in supplierServices.GetSuppliers())
// {
//     Console.WriteLine($"Id {item.Id}\nName {item.Name}\nPrice {item.Email}\nQuantity {item.Phone}");
// }

// supplierServices.UpdateSupplier(3, "Abdurahmon", "abdurahmon19#gmail.com", "2346692");
// foreach (var item in supplierServices.GetSuppliers())
// {
//     Console.WriteLine($"Id {item.Id}\nName {item.Name}\nPrice {item.Email}\nQuantity {item.Phone}");
// }

// supplierServices.DeleteProduct(2);
// foreach (var item in supplierServices.GetSuppliers())
// {
//     Console.WriteLine($"Id {item.Id}\nName {item.Name}\nPrice {item.Email}\nQuantity {item.Phone}");
// }