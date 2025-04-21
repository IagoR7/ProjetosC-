using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sortedlist();
            //sortedDictionary();
            //sortedSet();
            //queue();
            //stack();
            for (int i = 0; i < 100; i++) { Console.WriteLine(i); }
            


        }
        public static void sortedlist()
        {
            //USA MENOS MEMORIA
            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {21, "Ayel" },
                {10,"Neymar" },
                {26, "Iago" }
            };
            alunos.Add(17, "Kami");
            //alunos.Reverse();
            //alunos.Remove(10);
            //alunos.RemoveAt(0);
            //alunos.Count();
           // alunos.ContainsKey(26);
           // alunos.ContainsValue("Iago");
            foreach (KeyValuePair<int, string> item in alunos.Reverse())//.reverse para decrescente
            {
                Console.WriteLine(item);
            }
            

            Console.ReadLine();
        }
     
        public static void sortedDictionary()
        {
            //TEM OPEREÇÃOES MAIS RAPIDAS
            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>()
            {
                {11, "Neymar" },
                {10, "Messi" },
                {9, "Suarez" }
            };
            alunos.Add(7 , "CR7");
            alunos.Reverse();

            foreach (KeyValuePair<int, string> item in alunos)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        public static void sortedSet()
        {
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Iago", "Sunny", "Arthur", "KimDokja", "Simon", 123.ToString(),
            };
            if (!nomes.Add("lelouch")) // ! = se o metodo retorna false imprime o if
            {
                Console.WriteLine("não pode repitir o valor");
            }

            //nomes.reverse();
            //nomes.Remove("Sunny");
            //nomes.Last();
            //nomes.Count();
            //Console.WriteLine(nomes.ElementAt(1));
            //Console.WriteLine(" ");
            foreach (string item in nomes)
            {
                Console.WriteLine(item);

            }
            
            Console.ReadLine();
        }

        public static void queue()
        {
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Iago");
            fila.Enqueue("Sunny");
            fila.Enqueue("Arthur");

            string lista = "";
            Console.WriteLine($"{ fila.Count()} pessoas estão na fila nesse momento");
            foreach (string item in fila)
            {
                lista += item + ", ";
            }
            if (lista.EndsWith(", "))
            {
                lista = lista.Substring(0, lista.Length - 2);
            }

            /*Console.WriteLine("");
            Console.WriteLine($"Primeiro da fila é {fila.Peek()}\n");// Não Remove a pessoa da lista
            Console.WriteLine($"{fila.Count()} pessoas estão na fila nesse momento\n");
            Console.WriteLine($"Primeiro da fila é {fila.Dequeue()}\n");//remove a pessoa da lista
            Console.WriteLine($"{fila.Count()} pessoas estão na fila nesse momento\n");
            Console.WriteLine($"Primeiro da fila é {fila.First()}\n");// Não Remove a pessoa da lista*/

            while(fila.Count > 0)
            {
                Console.WriteLine("Primeiro da fila " + fila.Dequeue());
                Console.WriteLine(fila.Count);
                foreach (string item in fila)
                {
                    Console.WriteLine(item);
                }
                    
            }
            Console.ReadLine();

        }

        public static void stack()
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Iago");
            pilha.Push("Sunny");
            pilha.Push("Arthur");

            //Console.WriteLine(pilha.Count + "\n");

           /*foreach (string item in pilha)
            {
                Console.WriteLine(item + "\n");
            }*/

            //Console.WriteLine(pilha.Peek());//retorna objeto do topo da pilha sem removelo
            
            //Console.WriteLine(pilha.Pop());//Retorna o ojeto do topo da pilha mas vai removelo
            
            pilha.Clear();
            while (pilha.Count > 0)
            {   
                Console.WriteLine(pilha.Count);
                Console.WriteLine(pilha.Pop());
                
                foreach (string item in pilha)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }

    }

    
}
