using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {        
        static void Main(string[] args)
        {
            TaskClass taskObj = new TaskClass();

            MyThreadPool threadPool = new MyThreadPool(2, 8);

            TaskQueue testTask = new TaskQueue(taskObj.Test, null);

            threadPool.AddTaskInQueue(testTask);

            threadPool.DirectON();

            threadPool.AddTaskInQueue(testTask);

            threadPool.DirectON();

            threadPool.AddTaskInQueue(testTask);

            threadPool.DirectON();

            Console.ReadKey();
        }
    }
}
