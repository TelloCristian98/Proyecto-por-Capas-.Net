using Entities;
using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VDL;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //addCategoryandProduct();
            string baseAddress = "http://localhost:9000/";

            // Start OWIN host
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("Web API running at " + baseAddress);
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
        //static void addCategoryandProduct()
        //{
        //    var category = new Categories ();
        //    category.CategoryName = "Beverages";
        //    category.Description = "Soft drinks, coffees, teas, beers, and ales";

        //    var product = new Products();
        //    product.ProductName = "Chai";
        //    product.UnitPrice = 18.00M;
        //    product.UnitsInStock = 39;

        //    category.Products.Add(product);

        //    using (var repository = RepositoryFactory.CreateRepository())
        //    {
        //        repository.Create(category);
        //    }

        //    Console.WriteLine($"Category: {category.CategoryName}, Product: {product.ProductName}");
        //    Console.ReadLine();
        //}
    }

}
