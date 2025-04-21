using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEnvironment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //Environment = Ambiente
            string meuDocs =  Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Environment.CurrentDirectory = "C:\\";
            string dirAtual = Environment.CurrentDirectory;

            //Environment.NewLine; quebra de linha
            int num1 = 2;
            
            string varAmb = Environment.GetEnvironmentVariable("Path");


            //List<string> discos = Environment.GetLogicalDrives().ToList();

            /*string[] discos = Environment.GetLogicalDrives();
            foreach (var item in discos)
            {
                Console.WriteLine("\n" + item);
            }*/

            string user = Environment.UserName;
            string Dominio = Environment.UserDomainName;
            int cpu =  Environment.ProcessorCount;
            

            Console.WriteLine(cpu);


            Console.ReadLine();
        }
    }
}
