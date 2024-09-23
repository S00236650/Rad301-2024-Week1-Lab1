using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;
using ProductModel;

namespace Rad301_2024_Week1_Lab1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ProductModelCreator pmc = new ProductModelCreator();

            List<Category> categories = new List<Category>();
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();
            List<SupplierProduct> suppliersProducts = new List<SupplierProduct>();

            categories = pmc.ReturnCategories();
            products = pmc.ReturnProducts();
            suppliers = pmc.ReturnSuppliers();
            suppliersProducts = pmc.ReturnSupplierProducts();

            Console.WriteLine(categories[0].ToString());

            // Wait for input to close app
            Console.ReadKey();
        }
    }
}
