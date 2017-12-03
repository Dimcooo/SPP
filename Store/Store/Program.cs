using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Products;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Dmitry", 100, 5.5);

            Console.WriteLine("List of products:");

            Candy candy = new Candy("Red Beanie", 0.5, "Red October");
            Bread bread = new Bread("Bread", 0.6, "Bread Factory");

            Product[] products = new Product[]
            {
                candy, bread
            };

            for (int i = 0; i < products.Length; i++)
                PrintInfo(products[i]);

            Console.ReadKey();
        }

        public static void PrintInfo(Product product)
        {
            Console.WriteLine(Environment.NewLine + product.ToString());
            Console.WriteLine("Name: " + product.Name);
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Manufacturer: " + product.Manufacturer);
            Console.WriteLine(new String('-', 25) + Environment.NewLine);
        }
    }
}
