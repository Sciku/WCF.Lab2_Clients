using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Lab2_ConsoleClientThousandDays
{
    class Program
    {
        static void Main(string[] args)
        {
            ThousandDaysClient host = new ThousandDaysClient();
            Console.WriteLine("Skriv in året du är född: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in månaden du är född: ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in dagen du är född: ");
            var day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(host.days(year, month, day) + " dagar kvar till du fyller jämt antal 1000 år");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
