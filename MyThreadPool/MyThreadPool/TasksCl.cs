using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyThreadPool
{
    class TasksCl
    {
        public static void EmptyTsk(object obj = null)
        {
            Thread.Sleep(1000);
        }

        public static void SomeMethod(object obj = null)
        {
            string something = "I" + " want" + " something" + " just" + " like" + " this.";
            string other = something;
        }

        public static void SomeOtherMethod(object obj = null)
        {
            int a = 352365265;
            int b = a % 'g';
        }
    }
}
