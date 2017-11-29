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
        private int count = 0, countTask = 0;
        private CancellationTokenSource cnclTkn = new CancellationTokenSource();

        private TaskClass task = new TaskClass();
        private Queue<TaskQueue> queueTask = new Queue<TaskQueue>();
        private object syncQueue = new object();

        public void AddTaskInQueue(TaskQueue task)
        {
            lock (syncQueue)
            {
                Console.WriteLine("Task added");
                queueTask.Enqueue(task);
                countTask++;
            }
        }

        public void DirectON()
        {
            DirectionThread();            
        }

        public MyThreadPool(int min, int max)
        {
            this.minCountThread = min;
            this.maxCountThread = max;
        }

        public void DirectionThread()
        {
            for (int i = 0; i < countTask; i++)
            {            
                MakeThread();
                count++;
            }
        }

        public void MakeThread()
        {
            var newThrd = new Task(WorkForThread, cnclTkn.Token, TaskCreationOptions.LongRunning);
            newThrd.Start();
        }

        public void WorkForThread()
        {
            //task.Test();

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

            //if (count >= minCountThread)
            //{
            //    if (count <= maxCountThread)
            //    {                    
            //        MakeThread();
            //        count++;
            //    }
            //}
        }
    }
}
