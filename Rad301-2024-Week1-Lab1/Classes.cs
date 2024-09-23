using Classes;
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
        public string Description;

        public Category() { }

        public Category(int id, string description)
        {
            CategoryId = id;
            Description = description;
        }

        public override string ToString()
        {
            return "Category ID: " + CategoryId + ", Description: " + Description;
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

        public override string ToString()
        {
            return "Product ID: " + ProductId + ", Description: " + Description + ", Quantity: " + QuantityInStock + ", Unit Price: " + UnitPrice + ", Category ID: " + CategoryId;
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

        public override string ToString()
        {
            return "Supplier ID: " + SupplierId + ", Supplier Name: " + SupplierName + ", Address: " + SupplierAddressLine1 + ", " + AddressLine2;
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

        public override string ToString()
        {
            return "Supplier ID: " + SupplierId + ", Product ID: " + ProductId + "Date First Offered: " + DateFirstSupplied.Day + "/" + DateFirstSupplied.Month + "/" + DateFirstSupplied.Year;
        }
    }
}

namespace ProductModel
{
    public class ProductModelCreator
    {
        List<Category> categories = new List<Category>();
        List<Product> products = new List<Product>();
        List<Supplier> suppliers = new List<Supplier>();
        List<SupplierProduct> suppliersProducts = new List<SupplierProduct>();

        public void CreateModel()
        {
            // Create categories and add to list
            Category cat1 = new Category(1, "Hardware");
            Category cat2 = new Category(2, "Electrical Appliances");
            categories.Add(cat1);
            categories.Add(cat2);

            // Create products and add to list
            Product prod1 = new Product(1, "9 Inch Nails", 200, 0.1f, cat1);
            Product prod2 = new Product(2, "9 Inch Bolts", 120, 0.2f, cat1);
            Product prod3 = new Product(3, "Chimney Hoover", 10, 100.3f, cat2);
            Product prod4 = new Product(4, "Washing Machine", 7, 399.5f, cat2);
            products.Add(prod1);
            products.Add(prod2);
            products.Add(prod3);
            products.Add(prod4);

            // Create suppliers and add to list
            Supplier sup1 = new Supplier(1, "ACME", "Collooney", "Sligo");
            Supplier sup2 = new Supplier(2, "Swift Electric", "Finglas", "Dublin");
            suppliers.Add(sup1);
            suppliers.Add(sup2);

            // Create supplier products and add to list
            SupplierProduct supProd1 = new SupplierProduct(sup1, prod1, new DateTime(2012, 12, 12));
            SupplierProduct supProd2 = new SupplierProduct(sup1, prod2, new DateTime(2017, 08, 13));
            SupplierProduct supProd3 = new SupplierProduct(sup2, prod3, new DateTime(2022, 09, 09));
            SupplierProduct supProd4 = new SupplierProduct(sup2, prod4, new DateTime(2024, 04, 11));
            suppliersProducts.Add(supProd1);
            suppliersProducts.Add(supProd2);
            suppliersProducts.Add(supProd3);
            suppliersProducts.Add(supProd4);
        }

        public List<Category> ReturnCategories()
        {
            return categories;
        }

        public List<Product> ReturnProducts()
        {
            return products;
        }

        public List<Supplier> ReturnSuppliers()
        {
            return suppliers;
        }

        public List<SupplierProduct> ReturnSupplierProducts()
        {
            return suppliersProducts;
        }
    }
}
