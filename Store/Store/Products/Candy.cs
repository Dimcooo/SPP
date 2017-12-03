using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Products
{
    class Candy : Product
    {
        public Candy(string name, double price, string manuf)
        {
            Name = name;
            Price = price;
            Manufacturer = manuf;
        }
    }
}
