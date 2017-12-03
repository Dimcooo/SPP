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

        public virtual double Discont()
        {
            return Price;
        }
    }
}
