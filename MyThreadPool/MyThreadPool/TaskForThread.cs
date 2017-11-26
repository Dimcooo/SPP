using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyThreadPool
{
    public class TaskForThread
    {
        public delegate void backDel(object state);

        public backDel deleg;
        public object state;

        public TaskForThread(backDel deleg, object state)
        {
            this.deleg = deleg;
            this.state = state;
        }
    }
}
