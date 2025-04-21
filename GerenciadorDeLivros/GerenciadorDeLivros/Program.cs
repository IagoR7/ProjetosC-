using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GerenciadorDeLivros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gerenciador g = new Gerenciador();
            Console.Write("Seja Bem vindo a Biblioteca!!! \ndeseja ver a lista de livros? ");
            string verliv = Console.ReadLine();
            if (verliv.ToLower() == "sim")
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("\n----- LISTA DE LIVROS -------\n");

                foreach (var autor in g.livrosdisp)
                {
                    Console.WriteLine($"Autor: {autor.Key}\n");

                    foreach (var livro in autor.Value)
                    {
                        Console.WriteLine($"   - {livro}\n");
                    }
                }

            }
            else
            {
                Console.WriteLine("Até um proximo dia então");
                return;
            }

            string opcao = "";

            while (opcao.ToLower() != "sair")
            {
                Thread.Sleep(1000);

                Console.WriteLine("");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Remover");
                Console.WriteLine("3 - Procurar");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Digite o nome do Autor para Adicionar: ");
                        string AddAUTOR = Console.ReadLine();
                        Console.Write("Digite o nome do Livro para Adicionar: ");
                        string AddLivro = Console.ReadLine();

                        g.Adicionar(AddAUTOR, AddLivro);
                        Console.WriteLine("Atualizando a Lista De Livros...");
                        Thread.Sleep(1000);

                        Console.WriteLine($"Lista De livros Atualizada no dia {DateTime.Now}");

                        foreach (var autor in g.livrosdisp)
                        {
                            Console.WriteLine($"Autor: {autor.Key}\n");

                            foreach (var livro in autor.Value)
                            {
                                Console.WriteLine($"   - {livro}\n");
                            }
                        }
                        
                        break;

                    case "2":
                        Console.Clear();
                        Console.Write("Digite o nome do Autor para Remover: ");
                        string RemoveAUTOR = Console.ReadLine();
                        Console.Write("Digite o nome do Livro para Remover: ");
                        string RemoveLivro = Console.ReadLine();

                        g.Remover(RemoveAUTOR, RemoveLivro);

                        Console.WriteLine("Atualizando a Lista De Livros...");
                        Thread.Sleep(1000);
                        Console.WriteLine($"Lista De livros Atualizada no dia {DateTime.Now}");

                        foreach (var autor in g.livrosdisp)
                        {
                            Console.WriteLine($"Autor: {autor.Key}\n");

                            foreach (var livro in autor.Value)
                            {
                                Console.WriteLine($"   - {livro}\n");
                            }
                        }
                        
                        break;

                    case "3":
                        Console.WriteLine("Digite O livro Que Você Procura: ");
                        string findBook = Console.ReadLine();
                        g.Procurar(findBook);
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
            Console.ReadLine();
            }
        }
    }

