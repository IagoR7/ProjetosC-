using System;

class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine(TimeSpan.FromMinutes(60));
        //Console.WriteLine(TimeSpan.FromDays(7.25));
        //Console.WriteLine(TimeSpan.FromTicks(10000000000)); 

        TimeSpan inicio = new TimeSpan(1, 0, 0);

        TimeSpan fim = new TimeSpan(3, 30,00);
        
        //TimeSpan intervalo = fim - inicio;

        //TimeSpan totaltemp = fim + inicio;

        TimeSpan totaltemp = inicio.Add(fim);
        TimeSpan intervalo = fim.Subtract(inicio);


        Console.WriteLine(totaltemp);//.hours retorna apenas as horas / .TotalHours retorna as horas totais
        Console.ReadLine();
    }
}
