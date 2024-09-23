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
            // Tranfer all to Main
            ProductModelCreator pmc = new ProductModelCreator();

            pmc.CreateModel();
            List<Category> categories = new List<Category>();
            List<Product> products = new List<Product>();
            List<Supplier> suppliers = new List<Supplier>();
            List<SupplierProduct> suppliersProducts = new List<SupplierProduct>();

            categories = pmc.ReturnCategories();
            products = pmc.ReturnProducts();
            suppliers = pmc.ReturnSuppliers();
            suppliersProducts = pmc.ReturnSupplierProducts();

            // List all categories
            Console.WriteLine("All Categories:");

            var allCats = from c in categories
                          select c;

            foreach (var cat in allCats)
                Console.WriteLine(cat.ToString());

            // List all products
            Console.WriteLine("\nAll Products:");

            var allProds = from p in products
                           select p;

            foreach (var prods in allProds)
            {
                Console.WriteLine(prods.ToString());
            }

            // List all products with a quantity of <=100
            Console.WriteLine("\nProducts with a stock of 100 or less:");

            var lessThan101Prods = from p in products
                                   where p.QuantityInStock <= 100
                                   select p;

            foreach (var prods in lessThan101Prods)
                Console.WriteLine(prods.ToString());

            // List all products with a quantity of >120
            Console.WriteLine("\nProducts with a stock of 120 or more:");

            var moreThan120Prods = from p in products
                                   where p.QuantityInStock > 120
                                   select p;

            foreach (var prods in moreThan120Prods)
                Console.WriteLine(prods.ToString());

            // Display the total value for all products
            Console.WriteLine("\nTotal value of all products: ");

            foreach (var prods in allProds)
            {
                Console.WriteLine("Product: " + prods.Description + ", Total value: " + (prods.UnitPrice * prods.QuantityInStock));
            }

            // List all products in the hardware category
            Console.WriteLine("\nProducts in the hardware category:");

            var hardware = from p in products
                           where p.CategoryId == 1
                           select p;

            foreach (var prods in hardware)
                Console.WriteLine(prods.ToString());

            // List all suppliers and their parts
            Console.WriteLine("\nSuppliers and their products:");

            var query = (from s in suppliers
                        join sp in suppliersProducts on s.SupplierId equals sp.SupplierId
                        join p in products on sp.ProductId equals p.ProductId
                        select new
                        {
                            SupplierName = s.SupplierName,
                            ProductDescription = p.Description
                        }).OrderByDescending(x => x.SupplierName);

            foreach (var prods in query)
            {
                Console.WriteLine(prods.SupplierName + ":");
                Console.WriteLine(prods.ProductDescription);
            }

            // Wait for input to close app
            Console.ReadKey();
        }
    }
}
