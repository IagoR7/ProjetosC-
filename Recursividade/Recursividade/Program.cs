using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            recursivo r = new recursivo();
            r.executar("Olá mundo", 5 );

            r.ExecutarRecursivo("olá mundo", 5);

            Console.ReadKey();

        }
    }
}
