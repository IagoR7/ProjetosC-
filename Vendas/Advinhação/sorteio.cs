using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Regras_De_Negocio
{
    internal class sorteio
    {
        public class JogoAdivinhacao
        {
            public static void Adivinhar()
            {
                Random rand = new Random();
                int secret = rand.Next(1, 101); // Gera um número aleatório entre 1 e 100
                int valor;

                Console.WriteLine("Tente adivinhar o número secreto!");

                while (true)
                {
                    Console.Write("Digite um número: ");

                    // Verifica se a entrada é um número válido
                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        if (valor > secret)
                        {
                            Console.WriteLine("O número secreto é menor!");
                        }
                        else if (valor < secret)
                        {
                            Console.WriteLine("O número secreto é maior!");
                        }
                        else
                        {
                            Console.WriteLine("Você Acertou!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, digite um número válido!");
                    }
                }
            }
        }
    }
}
