using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.Write("Digite o Nome Da conta: ");
            string nomeconta = Console.ReadLine();
            c.Cliente = nomeconta;

            if (c.Cliente != "sunny" && c.Cliente != "iago")
            {
                Console.WriteLine("Deseja se registrar? (sim/não)");
                string resposta = Console.ReadLine();
                if (resposta.ToLower() == "sim")
                {
                    Console.Write("Digite o seu nome: ");
                    string nomeV = Console.ReadLine();
                    Console.WriteLine($"Olá {nomeV}!");
                }
                else
                {
                    Console.WriteLine("VLW ENTÃO");
                    return;
                }
            }
            


            string opcao = "";

            while (opcao.ToLower() != "sair")
            {
                Console.WriteLine($"\nBem-vindo, {c.Cliente}!");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver Saldo");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o valor para depositar: ");
                        double valorDep = Convert.ToDouble(Console.ReadLine());
                        c.Depositar(valorDep);
                        break;

                    case "2":
                        Console.Write("Digite o valor para sacar: ");
                        double valorSaq = Convert.ToDouble(Console.ReadLine());
                        c.Sacar(valorSaq);
                        break;

                    case "3":
                        Console.WriteLine($"Saldo atual: {c.Saldo}");
                        break;

                    case "4":
                    case "sair":
                        opcao = "sair";
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            Console.WriteLine("VLW VLW");
            Console.ReadKey();
        }
    }
}


