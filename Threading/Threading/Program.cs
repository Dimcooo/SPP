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

            MyThreadPool threadPool = new MyThreadPool(4, 8);
            TaskQueue testTask = new TaskQueue(taskObj.Test, null);
            TaskQueue testTaskSec = new TaskQueue(taskObj.SecondTest, null);

            for (int i = 0; i < 10; i++)
            {
                threadPool.AddTaskInQueue(testTask);
                threadPool.AddTaskInQueue(testTaskSec);
            }            
            Console.ReadKey();
        }
    }
}
