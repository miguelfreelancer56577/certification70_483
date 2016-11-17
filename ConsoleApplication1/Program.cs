using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public static void threadMethod() {
            Console.WriteLine("second method");
            for (int i = 0; i < 10; i++ )
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(threadMethod));
            t.IsBackground = true;
            t.Start();
            //Console.WriteLine("main method");
        }
    }
}
