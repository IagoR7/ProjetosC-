using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClasseRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aleatorio();
            RRussa();
        }

        static void Aleatorio()
        {   
            Random R = new Random(DateTime.Now.Millisecond);
            //(100) vai até 99 pq o 100 ele exclui / (0,10) valor minino, valor maximo
            int valor = R.Next(99);
            double valor2 = R.NextDouble();
            Console.WriteLine(valor);
            Console.ReadLine();
        }
        static async void RRussa()
        {
            Random r = new Random();
            int valor = r.Next(1,7);
            int resultado = 0;

            while (valor != resultado)
            {
                Console.Write("Escolhea um numero entre 1 a 6 : ");
                resultado = int.Parse(Console.ReadLine());

                if (resultado == valor)
                {
                    
                    Console.Write("...\n...\n...\n... ");
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Girando o Tambor novamente");
                    Thread.Sleep(1000);

                    
                }
            }
            Console.ReadLine();
        }
    }
}
