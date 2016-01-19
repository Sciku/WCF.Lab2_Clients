using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Lab2_ConsoleClientDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysClient host = new DaysClient();
            Console.WriteLine("Skriv in året du är född: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in månaden du är född: ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in dagen du är född: ");
            var day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(host.DaysOld(year, month, day));
            System.Threading.Thread.Sleep(5000);
        }
    }
}
