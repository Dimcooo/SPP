using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Tape
    {
        public void Scan(User user, Product product)
        {
            Console.WriteLine(user.Name + " u buy: " + product.Name + ", in quality: " + product.Count);

            if(product.Count / 3 > 0)
            {
                Console.WriteLine($"Product cost = {((product.Count * product.Price)) - ((product.Count / 3) * product.Price)}");
            }
            else
            {
                Console.WriteLine($"Product cost {product.Price * product.Count}");
            }
        }

        public void Check()
        {
            
        }
    }
}
