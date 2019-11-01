using System;
using System.Collections.Generic;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product manager");

            Product p1 = new Product("java", "java programming", 59.50);
            Product p2 = new Product
            {
                Code = "c#",
                Description = "Murach's Java Programming",
                Price = 57.50
            };

            Product p3 = new Product("mysql", "mysql programming", 19.99);

            Product[] products = { p1, p2, p3 };

            foreach (Product pdt in products)
            {
                Console.WriteLine(pdt); 
            }

            Console.WriteLine(products[2]);

            List<Product> productsList = new List<Product>
            {
                p1,
                p2,
                p3
            };

            Console.WriteLine("array list version of listing products");
            foreach (Product pdt in productsList)
            {
                Console.WriteLine(pdt);
            }


            Console.WriteLine("using a dictionary to store products");
            Dictionary<string, Product> productsMap = new Dictionary<string, Product>();
            productsMap.Add(p1.Code, p1);
            productsMap.Add(p2.Code, p2);
            productsMap.Add(p3.Code, p3);

            string code = MyConsole.getString("Enter product code to look up: ");
            Console.WriteLine("Product = " + productsMap[code]);




            Console.WriteLine("bye");
        }
    }
}
