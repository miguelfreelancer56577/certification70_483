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

        public static void threadMethod(object o) {
            for (int i = 0; i < (int)o; i++ )
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main(string[] args)
        {
            Thread t = new Thread(new ParameterizedThreadStart(threadMethod));
            t.Start(5);
            Console.WriteLine("main method first line");
            t.Join();
            Console.WriteLine("main method second line");
        }
    }
}
