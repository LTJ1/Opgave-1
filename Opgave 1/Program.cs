using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Udskriv tekst til skærm
            Console.WriteLine("Indtasat navn:");
            string Navn;
            
            // Læs tekst fra skærm
            Navn = Console.ReadLine();
            string StortNavn;
            // Konverter navn til store bogstaver
            StortNavn = Navn.ToUpper();

            // Udskriv navn med store bogstaver ....
            Console.WriteLine("Velkommen " + StortNavn);
            Console.WriteLine("Tryk en tast for at fortsætte");
            Console.ReadKey();
        }
    }
}
