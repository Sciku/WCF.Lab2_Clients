using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Lab2_ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BMIClient host = new BMIClient();
            Console.WriteLine("Skriv in längd: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Skriv in vikt: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine(host.BMI(height, weight));
            System.Threading.Thread.Sleep(5000);

        }
    }
}
