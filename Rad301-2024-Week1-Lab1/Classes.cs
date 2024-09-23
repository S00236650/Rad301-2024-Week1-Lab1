using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Category
    {
        public int CategoryId;
        public int Description;

        public Category() { }

        public Category(int id, int description)
        {
            CategoryId = id;
            Description = description;
        }
    }

    public class Product
    {
        public int ProductId;
        public string Description;
        public int QuantityInStock;
        public float UnitPrice;
        public int CategoryId;

        public Product() { }

        public Product(int id, string description, int stock, float price, Category cat)
        {
            ProductId = id;
            Description = description;
            QuantityInStock = stock;
            UnitPrice = price;
            CategoryId = cat.CategoryId;
        }
    }

    public class Supplier
    {
        public int SupplierId;
        public string SupplierName;
        public string SupplierAddressLine1;
        public string AddressLine2;

        public Supplier() { }

        public Supplier(int id, string name, string addressLine1, string addressLine2)
        {
            SupplierId = id;
            SupplierName = name;
            SupplierAddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
        }
    }

    public class SupplierProduct
    {
        public int SupplierId;
        public int ProductId;
        public DateTime DateFirstSupplied;

        public SupplierProduct() { }

        public SupplierProduct(Supplier sup, Product product, DateTime date)
        {
            SupplierId = sup.SupplierId;
            ProductId = product.ProductId;
            DateFirstSupplied = date;
        }
    }
}
