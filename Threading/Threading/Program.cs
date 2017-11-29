using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {        
        static void Main(string[] args)
        {
            MyThreadPool threadPool = new MyThreadPool(3, 6);

            Console.ReadKey();
        }
    }
}
