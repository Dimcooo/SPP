using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace MyThreadPool
{
    public partial class Form1 : Form
    {
        private IThreadPool threadPool;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int min = 0, max = 0;
            try
            {
                min = Int32.Parse(minNumbTask.Text);
                max = Int32.Parse(maxNumbTask.Text);

                if((min <= 0) && (min > max)){
                    throw new Exception("Wrong values");
                }

                threadPool = new ThreadPool(min, max);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void btnFrstMeth_Click(object sender, EventArgs e)
        {
            TaskForThread testTask = new TaskForThread(TasksCl.EmptyTsk, null);
            threadPool.AddTaskToQueue(testTask);
        }

        private void btnSecMeth_Click(object sender, EventArgs e)
        {
            TaskForThread testTask = new TaskForThread(TasksCl.SomeMethod, null);
            threadPool.AddTaskToQueue(testTask);
        }

        private void btnThrdMeth_Click(object sender, EventArgs e)
        {
            TaskForThread testTask = new TaskForThread(TasksCl.SomeOtherMethod, null);
            threadPool.AddTaskToQueue(testTask);
        }
    }
}
