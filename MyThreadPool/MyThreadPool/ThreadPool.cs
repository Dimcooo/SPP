using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.Threading;

namespace MyThreadPool
{
    public class ThreadPool : IThreadPool
    {
        private int MinNumbOfThread { get; set; }
        private int MaxNumbOfThread { get; set; }

        private static Logger log;

        private CancellationTokenSource cancelTokenSourse = new CancellationTokenSource();

        private List<int> NumbOfThreads = new List<int>();
        private Queue<TaskForThread> queueTask = new Queue<TaskForThread>();
        private static AutoResetEvent resetEvent = new AutoResetEvent(true);

        private object ListLocker = new object();
        private object syncronizeQueue = new object();

        public ThreadPool(int minNumbOfThread, int maxNumbOfThread)
        {            
            GetNumbOfThreads(minNumbOfThread, maxNumbOfThread);

            log = LogManager.GetCurrentClassLogger();

            for (int i = 0; i < minNumbOfThread; i++)
            {
                AddNewThread();
            }
        }

        public void GetNumbOfThreads(int min, int max)
        {
            this.MinNumbOfThread = min;
            this.MaxNumbOfThread = max;
        }

        private void AddNewThread()
        {
            var newThrd = new Task(ActionForThread, cancelTokenSourse.Token, TaskCreationOptions.LongRunning);

            lock (ListLocker)
            {
                NumbOfThreads.Add(newThrd.Id);
            }

            log.Info("Created stream with number: " + newThrd.Id);

            newThrd.Start();
        }

        public void AddTaskToQueue(TaskForThread task)
        {
            log.Info("New task added.");

            lock (syncronizeQueue)
            {
                queueTask.Enqueue(task);
                resetEvent.Set();
            }
        }

        public void ActionForThread()
        {
            TaskForThread task;
            bool isEvent = false;
            do
            {
                if (queueTask.Count() >= 2 && ThreadSize() == MaxNumbOfThread)
                {
                    log.Info("Maximum count of threads");
                    MaxNumbOfThread++;
                    AddNewThread();
                }

                if (queueTask.Count() >= 2 && ThreadSize() < MaxNumbOfThread)
                {
                    AddNewThread();
                }

                task = GetTaskFromQueue();

                if(task != null)
                {
                    TaskWorking(task);
                }
                else
                {
                    if(ThreadSize() > MinNumbOfThread)
                    {
                        isEvent = resetEvent.WaitOne(1000);
                    }
                    else
                    {
                        isEvent = resetEvent.WaitOne();
                    }

                    if (!isEvent)
                    {
                        if(ThreadSize() > MinNumbOfThread)
                        {
                            log.Info("Thread number " + Task.CurrentId + "stopped");
                            lock (ListLocker)
                            {
                                NumbOfThreads.Remove((int)Task.CurrentId);
                                cancelTokenSourse.Cancel();
                            }                          
                        }
                    }
                }

            }
            while (true);
        }

        private TaskForThread GetTaskFromQueue()
        {
            lock (syncronizeQueue)
            {
                if (queueTask.Count != 0)
                {
                    return queueTask.Dequeue();
                }
                else
                    return null;
            }
        }

        private int ThreadSize()
        {
            lock (ListLocker)
            {
                return NumbOfThreads.Count();
            }
        } 
        
        private void TaskWorking(TaskForThread task)
        {
            try
            {
                task.deleg(task.state);
            }
            catch (Exception e)
            {
                log.Info("Error of complete: " + e.Message);
            }
        }
    }
}
