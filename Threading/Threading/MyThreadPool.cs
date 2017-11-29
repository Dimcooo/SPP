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
        private int count = 0;
        private CancellationTokenSource cnclTkn = new CancellationTokenSource();
        private TaskClass task = new TaskClass();

        public MyThreadPool(int min, int max)
        {
            this.minCountThread = min;
            this.maxCountThread = max;

            DirectionThread();
        }

        public void DirectionThread()
        {
            for (int i = 0; i < minCountThread; i++)
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
            task.Test();
            //Console.WriteLine("Something");
            if (count >= minCountThread)
            {
                if (count <= maxCountThread)
                {                    
                    MakeThread();
                    count++;
                }
            }
        }
    }
}
