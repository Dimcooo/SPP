using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Count { get; set; }

        public virtual double Discont()
        {
            return Price;
        }

        public virtual void ProdToString() {
            Console.WriteLine(Environment.NewLine + ToString() + ".");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price.ToString());
            Console.WriteLine("Manufacturer: " + Manufacturer + Environment.NewLine);
            Console.WriteLine(new string('_', 25));
        }
    }
}
