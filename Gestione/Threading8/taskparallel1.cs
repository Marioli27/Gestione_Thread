using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Costruzione di un semplice task
            var simpleTask = Task.Factory.StartNew(() =>
            {
                  Thread.Sleep(1000);
                  Console.WriteLine("Ciao da simpleTask");
            });

            //Costruzione di un task con parametro in input
            var parameterTask = Task.Factory.StartNew((name) =>
            {
                 Thread.Sleep(1000);
                 Console.WriteLine("Ciao da parameterTask, {0}", name);

            }, "Matteo Tumiati");

            //Costruzione di un task che ritorna un risultato 
            var resultTask = Task.Factory.StartNew((inputValue) =>
              PerformSomeLongCalulation(inputValue), 5000D);

        }

        private static void PerformSomeLongCalulation(object inputValue)
        {
            throw new NotImplementedException();
        }
    }
}
