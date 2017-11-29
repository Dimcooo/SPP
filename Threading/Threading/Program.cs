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

            MyThreadPool threadPool = new MyThreadPool(3, 6);

            TaskQueue testTask = new TaskQueue(taskObj.Test, null);
            threadPool.AddTaskInQueue(testTask);
            threadPool.AddTaskInQueue(testTask);
            threadPool.AddTaskInQueue(testTask);
            threadPool.AddTaskInQueue(testTask);
            threadPool.AddTaskInQueue(testTask);

            threadPool.DirectON();

            Console.ReadKey();
        }
    }
}
