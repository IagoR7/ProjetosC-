using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras_De_Negocio
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "### REGRAS DE NEGOCIO ###";


            List<double> recebimento1p = new List<double>();
            List<double> recebimento2p = new List<double>();
            List<double> recebimento1r = new List<double>();
            List<double> recebimento2r = new List<double>();


            Console.Write("Digite a quantide de meses: ");
            int meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Primeira Previsão");

            for (int i = 0; i < meses; i++)
            {
                Console.Write($"Digite a {i + 1}º previsão: ");
                double valor = double.Parse(Console.ReadLine());
                recebimento1p.Add(valor);

            }

            Console.WriteLine("Segunda Previsão");

            for (int i = 0; i < meses; i++)
            {
                Console.Write($"Digite a {i + 1}º previsão: ");
                double valor = double.Parse(Console.ReadLine());
                recebimento2p.Add(valor);

            }
            Console.WriteLine("#################");

            Console.WriteLine("primeiro pagamento realizado");

            for (int i = 0; i < meses; i++)
            {
                Console.Write($"Digite o {i + 1}º pagamento de entrada realizado: ");
                double valor = double.Parse(Console.ReadLine());
                recebimento1r.Add(valor);

            }

            Console.WriteLine("Segunda pagamento realizado");

            for (int i = 0; i < meses; i++)
            {
                Console.Write($"Digite a {i + 1}º de entrada realizado: ");
                double valor = double.Parse(Console.ReadLine());
                recebimento2r.Add(valor);

            }


            double tentp = recebimento1p[0] + recebimento2p[0];
            double tentr = recebimento1r[0] + recebimento2r[0];

            Console.WriteLine($"total de entradas de previsão é {tentp} e de realizados é {tentr}");

            double forne = 1.500;
            double fpag = 3.000;
            double aluguel = 2.000;
            double luz = 500;
            double fgts = 1.900;

            double tudo = forne+fpag+aluguel+luz+fgts;

            double totalp = tentp - tudo;
            double totalr = tentr - tudo;
            Console.Write($"O saldo final da previsão é {totalp} e o saldo final realizado é {totalr}");
            Console.ReadKey();
        }
    }
}
