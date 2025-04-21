using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialRecursivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            resultado();

            
            Console.ReadKey();
        }

        static int numeros(int num1, int num2)
        { 
            return num1 + num2;
        }

        static void resultado()
        {
            Console.WriteLine(numeros(1,2));

        }
        static int Fatorial(int num)
        {

            if (num <= 0)
            {
                return 1;
            }
            return num * Fatorial(num - 1);
            // 5 * Fatorial(4);
            // 4 * Fatorial(3); 
            // 3 * Fatorial(2); 
            // 2 * Fatorial(1); 
            // 1 * Fatorial(0); 
            // return 1;
        }
    }
}
