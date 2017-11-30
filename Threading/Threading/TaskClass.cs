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
            int a = 5, b = 0;
            a = a / b;
        }

        public void SecondTest(object obj = null)
        {
            string a = "Something", b = "like this";
            a = a + b + 'c';
        }
    }
}
