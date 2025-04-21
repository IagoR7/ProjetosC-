using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace classeThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //thread = linha de execução de um sistema
            Thread t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true; // coloca a segundaria em segundo plano
            t.Start();// executa a principal e a segundaria ao mesmo tempo
            t.Join(); // a thread princial so executa depois da segundaria
            

            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal");
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }

        static void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa Executada");
                Thread.Sleep(1000);
            }
        }
    }
}
