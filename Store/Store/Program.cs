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
            Candy candy = new Candy("Red Beanie", 0.5, "Red October");
            Bread bread = new Bread("Bread", 0.6, "Bread Factory");

            Product[] products = new Product[]
            {
                candy, bread
            };

            Tape tape = new Tape();

            Console.WriteLine($"Sup {user.Name} ur balance {user.Balance}");

            while (true)
            {
                Console.WriteLine(Environment.NewLine + "List of products:" + Environment.NewLine);

                for (int i = 0; i < products.Length; i++)
                {
                    Console.Write(i + ".");
                    products[i].ProdToString();
                }

                do
                {
                    Console.WriteLine("Enter the numb of product, which u wanna buy");
                    string strNumbProd = Console.ReadLine();
                    int numbProd = Convert.ToInt32(strNumbProd);
                    Console.WriteLine("Enter the quality of " + products[numbProd]);
                    string strCountProd = Console.ReadLine();
                    products[numbProd].Count = Convert.ToInt32(strCountProd);

                    tape.Scan(user, products[numbProd]);
                    Console.WriteLine("Press enter to countinue, or 'exit' to exit");

                } while (Console.ReadLine() == "");
            }

            Console.ReadKey();
        }
    }
}
