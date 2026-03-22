using Domain.Entities;

namespace Infrastructure.Services;

public class SupplierServices
{
    private List<Supplier> suppliers = new List<Supplier>();


    public List<Supplier> GetSuppliers()
    {
        return suppliers;
    }


    public void CreateSupplier(Supplier supplier)
    {
        if (string.IsNullOrWhiteSpace(supplier.Name))
        {
            Console.WriteLine("Name is empty!");
            return;
        }

        foreach (var item in suppliers)
        {
            if (item.Id == supplier.Id)
            {
                Console.WriteLine("Duplicate Id!");
                return;
            }
        }
        suppliers.Add(supplier);
    }


    public void UpdateSupplier(int id, string name, string email, string phone)
    {
        foreach (var item in suppliers)
        {
            if (item.Id == id)
            {
                item.Name = name;
                item.Email = email;
                item.Phone = phone;
                return;
            }
        }
        Console.WriteLine("Supplier not found!");
    }


    public void DeleteSupplier(int id)
    {
        bool isfound = false;
        foreach (var item in suppliers)
        {
            if (item.Id == id)
            {
                suppliers.Remove(item);
                isfound = true;
                return;
            }
        }

        if (isfound == false)
        {
            Console.WriteLine("Supplier not found!");
        }
    }
}