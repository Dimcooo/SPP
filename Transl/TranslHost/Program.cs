using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TranslHost
{
    class Program
    {
        static void Main()
        {
            using (var host = new ServiceHost(typeof(Transl.Transl)))
            {
                host.Open();

                Console.WriteLine("Host started...");
                Console.ReadKey();
            }
        }
    }
}
