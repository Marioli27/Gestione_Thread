using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace THREAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(() =>
            {
                Console.WriteLine("MyThread è iniziato");
                Thread.Sleep(10000);
                Console.WriteLine("MyThread è terminato");

            });

            //esecuzione di myThread
            myThread.Start();

            Thread.Sleep(500);
            Console.WriteLine("Main Thread");

            Console.ReadLine();

        }
    }
}
