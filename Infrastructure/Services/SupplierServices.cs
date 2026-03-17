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
    }


    public void DeleteProduct(int id)
    {
        foreach (var item in suppliers)
        {
            if (item.Id == id)
            {
                suppliers.Remove(item);
                return;
            }
        }
    }
}