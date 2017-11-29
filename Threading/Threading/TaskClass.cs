using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class TaskClass
    {
        public void Test(object obj = null)
        {
            string name = "Thread " + ((Thread.CurrentThread.ManagedThreadId) - 2).ToString();
            Console.WriteLine($"{name} created");
            Thread.Sleep(1000);
            Console.WriteLine($"{name}: i do something just like this");
            Thread.Sleep(1000);
            Console.WriteLine($"{name} end");
        }

        public void SecondTest(object obj = null)
        {
            string name = "Thread " + ((Thread.CurrentThread.ManagedThreadId) - 2).ToString();
            Console.WriteLine($"{name} created");
            Thread.Sleep(1000);
            Console.WriteLine($"{name}: i do something just like this in the second time");
            Thread.Sleep(1000);
            Console.WriteLine($"{name} end");
        }
    }
}
