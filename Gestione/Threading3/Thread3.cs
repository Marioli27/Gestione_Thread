using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading3
{
    class Program
    {
        static void Main(string[] args)
        {
            string someVariable = "Matteo Tumiati";

            var workerThread = new Thread(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Saluti da: {0}", someVariable);

            });
            workerThread.Start();
            someVariable = "Daniele bochicchio";

            Console.ReadLine();
        }
    }
}
