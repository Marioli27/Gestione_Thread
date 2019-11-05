using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading4
{
    class Thread4
    {
        static void Main(string[] args)
        {
            var list = new List<Thread>();

            // Qui creiamo ed eseguiamo cinque worker thread 
            for (int index = 0; index < 5; index++)
           
            {
                var myThread = new Thread((currentIndex) =>
                {
                    Console.WriteLine("Thread {0} è iniziato", currentIndex);
                    Thread.Sleep(500);
                    Console.WriteLine("Thread {0} è terminato", currentIndex);
                });
                    myThread.Start(index);
                    list.Add(myThread);
            }

            foreach (Thread thread in list)
            {
                thread.Join();
            }

            Console.WriteLine("Esecuzione di tutti i thread terminata");
            //Attesa di massimo un secondo thread.Join(1000);
        }
    }
}
