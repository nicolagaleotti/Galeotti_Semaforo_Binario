using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Galeotti_Semaforo_Binario
{
    class Program
    {
        static int n = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                n = 0;
                Thread t1 = new Thread(() => Incrementa());
                t1.Start();

                Thread t2 = new Thread(() => Decrementa());
                t2.Start();

                while (t1.IsAlive) { }

                while (t2.IsAlive) { }

                Console.WriteLine(n);

                Console.ReadLine();
            }
        }

        private static void Incrementa()
        {
            for (int i = 0; i <= 1000000; i++)
            {
                n++;
            }
        }

        private static void Decrementa()
        {
            for (int i = 0; i <= 1000000; i++)
            {
                n--;
            }
        }
    }
}
