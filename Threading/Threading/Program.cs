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

            MyThreadPool threadPool = new MyThreadPool(1, 8);

            TaskQueue testTask = new TaskQueue(taskObj.Test, null);

            threadPool.AddTaskInQueue(testTask);

            Thread.Sleep(10000);
            threadPool.AddTaskInQueue(testTask);

            Thread.Sleep(10000);
            threadPool.AddTaskInQueue(testTask);

            Console.ReadKey();
        }
    }
}
