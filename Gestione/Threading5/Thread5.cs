using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading5
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerThread = new Thread(() =>
            {
                Console.WriteLine("Inizio di un thread molto lungo");
                Thread.Sleep(5000);
                Console.WriteLine("Termine worker thread");
            });

            workerThread.Start();
            workerThread.Join(500);

            //se il worker thread è ancora in esecuzione lo si cancella

            if(workerThread.ThreadState != ThreadState.Stopped)
            {
                workerThread.Abort();
            }

            Console.WriteLine("Termine applicazione");
        }
    }
}
