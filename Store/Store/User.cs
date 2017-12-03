using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class User
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }
        public double Spent { get; private set; }

        public User(string name, double balance, double spend)
        {
            Name = name;
            Balance = balance;
            Spent = spend;
        }

        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }
    }
}
