using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class MyThreadPool
    {
        private int minCountThread;
        private int maxCountThread;
        private int countTask = 0;
        private string name;

        private CancellationTokenSource cnclTkn = new CancellationTokenSource();

        private TaskClass task = new TaskClass();

        private Queue<TaskQueue> queueTask = new Queue<TaskQueue>();
        private object syncQueue = new object();
        private object syncNumbThreads = new object();
        

        public void AddTaskInQueue(TaskQueue task)
        {
            lock (syncQueue)
            {
                Console.WriteLine("Task added");
                queueTask.Enqueue(task);
                countTask++;
            }

            DirectON();
        }

        public void DirectON()
        {
            if (countTask <= minCountThread)
            {
                MakeThread();
            }
            else
            {
                Console.WriteLine("Max numb of threads");
                minCountThread++;
                MakeThread();
            }
        }

        public MyThreadPool(int min, int max)
        {
            Console.WriteLine("ThreadPool is created");
            this.minCountThread = min;
            this.maxCountThread = max;
        }

        public void MakeThread()
        {
            var newThrd = new Task(WorkForThread, cnclTkn.Token, TaskCreationOptions.LongRunning);
            newThrd.Start();
            lock (syncNumbThreads)
            {
                name = "Thread " + (newThrd.Id).ToString();
                Console.WriteLine($"{name} created");
            }
        }

        public void WorkForThread()
        {
            TaskQueue taskToDo;

            lock (syncQueue)
            {
                taskToDo = queueTask.Dequeue();
            }

            try
            {
                taskToDo.deleg(taskToDo.state);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            lock (syncNumbThreads)
            {
                Console.WriteLine($"Thread {Task.CurrentId} is deleted");
            }
        }
    }
}
