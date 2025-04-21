using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine($"{DateTime.Now}");
            //Console.WriteLine($"{DateTime.Today}");
            //Console.WriteLine($"{DateTime.DaysInMonth(2025,4)}");
            //Console.WriteLine($"{DateTime.IsLeapYear(2025)}");
            //Console.WriteLine($"{DateTime.Now.ToLongDateString()}");
            //Console.WriteLine($"{DateTime.Now.ToShortDateString()}");
            //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}");
            //Console.WriteLine($"{DateTime.Now.ToShortTimeString()}");
            //Console.WriteLine($"{DateTime.Now.ToUniversalTime()}");
            //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

            DateTime data = new DateTime(2004,01,10,14,35,30);
            //Console.WriteLine(data.AddYears(2)); 

            TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //Console.WriteLine(data.Add(tempo)); 
            Console.WriteLine(data.DayOfWeek);
            string dayofweek = data.DayOfWeek.ToString();
            if (dayofweek == "Saturday")
            {
                Console.WriteLine("Segunda - Feira");
            }
            

            Console.ReadLine();
        }
    }
}
