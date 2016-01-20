using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Lab2_ConsoleClientHobby
{
    public class Program
    {
        static void Main(string[] args)
        {
            HobbyClient host = new HobbyClient();
            Console.WriteLine("Skriv in ett år och få tillbaka vilken film som fick en Razzie för sämsta film det året");
            var year = Console.ReadLine();

            Console.WriteLine(host.WorstMovieTitle(year));
            System.Threading.Thread.Sleep(5000);
        }
    }
}
