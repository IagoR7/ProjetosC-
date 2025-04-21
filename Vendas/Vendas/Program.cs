using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "### Gérenciador De Vendas ###";
            double m1 = 100;
            double m2 = 100;
            double m3 = 100;

            double prodA = m1+ m2 + m3;

            double m1b = 200;
            double m2b = 200;
            double m3b = 200;

            double prodB = m1b + m2b + m3b;

            double m1c = 300;
            double m2c = 300;
            double m3c = 300;

            double prodC = m1c + m2c + m3c;

            double vmdA = ((m1 + m2 + m3) / 3) / 25;
            double vmdB = ((m1b + m2b + m3b) / 3) / 25;
            double vmdC = ((m1c + m2c + m3c) / 3) / 25;

            Console.Write("Digite o Tempo De Reposição: ");
            double tr = double.Parse(Console.ReadLine());

            double eminA = tr * vmdA;
            double eminB = tr * vmdB;
            double eminC = tr * vmdC;


            Console.Write("Digite o Lote De Reposição: ");
            double lr = double.Parse(Console.ReadLine());
            double emaxA = lr + eminA;
            double emaxB = lr + eminB;
            double emaxC = lr + eminC;

            Console.Write("Digite o Estoque atual A: ");
            double eaA = double.Parse(Console.ReadLine());

            if (eaA < eminA)
            {
                Console.WriteLine("comprar");
            }
            else
            {
                Console.WriteLine("Não Comprar");
            }
            Console.Write("Digite o Estoque atual B: ");
            double eaB = double.Parse(Console.ReadLine());

            if (eaB < eminB)
            {
                Console.WriteLine("comprar");
            }
            else
            {
                Console.WriteLine("Não Comprar");
            }
            Console.Write("Digite o Estoque atual C: ");
            double eaC = double.Parse(Console.ReadLine());

            if (eaC < eminC)
            {
                Console.WriteLine("comprar");
            }
            else
            {
                Console.WriteLine("Não Comprar");
            }



            Console.ReadKey();
        }
    }
}
