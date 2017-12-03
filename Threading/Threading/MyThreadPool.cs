using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;

namespace Threading
{
    class MyThreadPool
    {
        private int minCountThread;
        private int countTask = 0;
        private TaskClass task = new TaskClass();
        private Queue<TaskQueue> queueTask = new Queue<TaskQueue>();
        private object syncQueue = new object();
        private Logger log = new Logger();

        public void AddTaskInQueue(TaskQueue task)
        {
            lock (syncQueue)
            {
                log.Add(DateTime.Now.ToString() + " : " + "Task added");
                queueTask.Enqueue(task);
                countTask++;
            }
            DirectON();
        }

        public void DirectON()
        {
            if(countTask > minCountThread)
            {
                log.Add(DateTime.Now.ToString() + " : " + "Min numb of threads");
                minCountThread++;
            }
            MakeThread();
        }

        public MyThreadPool(int min, int max)
        {
            log.ClearFile();
            log.Add(DateTime.Now.ToString() + " : " + "ThreadPool is created");
            this.minCountThread = min;
        }

        public void MakeThread()
        {
            var newThrd = new Task(WorkForThread, TaskCreationOptions.LongRunning);
            newThrd.Start();
            log.Add(DateTime.Now.ToString() + " : Thread: " + $"{(newThrd.Id).ToString()} created");            
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
            catch (Exception ex)
            {
                log.Add(DateTime.Now.ToString() + " : " + $"{ex.Message}");
            }
        }
    }
}
