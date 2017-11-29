using System;
using System.Collections.Generic;
using System.Text;

namespace Threading
{
    class TaskQueue
    {
        public delegate void TasksDelegate(object state);

        public TasksDelegate deleg;

        public object state;

        public TaskQueue(TasksDelegate deleg, object state)
        {
            this.deleg = deleg;
            this.state = state;
        }
    }
}
