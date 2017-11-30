using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Threading
{
    public class Logger
    {
        private const string FileName = "log.txt";

        private object syncObj = new object();

        public void Add(string logInfo)
        {
            lock (syncObj)
            {
                using (var fs = new FileStream(FileName, FileMode.Append))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(logInfo + "\r\n");
                    fs.Write(array, 0, array.Length);
                }
            }
        }

        public void ClearFile()
        {
            using (var fs = new FileStream(FileName, FileMode.Create)) { }
        }
    }
}
