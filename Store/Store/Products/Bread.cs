using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    class Bread : Product
    { 
        public Bread(string name, double price, string manuf)
        {
            Name = name;
            Price = price;
            Manufacturer = manuf;
        }

        public override string ToString()
        {
            return "Bread";
        }

        public override void ProdToString()
        {
            base.ProdToString();
        }
    }
}
