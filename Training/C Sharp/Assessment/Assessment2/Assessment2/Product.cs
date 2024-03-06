using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment2
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}: ");
                Product product = new Product();

                Console.WriteLine("Product ID: ");
                product.ProductId = Convert.ToInt32(Console.ReadLine()); 
                
                Console.WriteLine("Product Name: ");
                product.ProductName = Console.ReadLine();

                Console.WriteLine("Price: ");
                product.Price = Convert.ToDouble(Console.ReadLine());
                products[i] = product;


            }

            Array.Sort(products, (x, y) => x.Price.CompareTo(y.Price));

            Console.WriteLine("Sorted Products Based on Price: ");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, price: {product.Price} ");
            }
        }
    }
}
