using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fornavn
            String fn = "Mikkel";
            //Efternavn
            string ef = "Cronberg";

            //Skriv samlet navn
            string samletNavn = $"{fn} {ef}";
            Console.WriteLine(samletNavn);

            //Konverterer samletNavn til store bogstaver 
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            //Konverterer samletNavn til små bogstaver 
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            // Udskriv en del af det samlede navn "Cron"
            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);

            //Udskriv arrayet med Mikkel i index 0 og Cronberg i index 1
            string[] navne = samletNavn.Split(' ');
            
            foreach ( var item in navne)
                Console.WriteLine(item);
            Console.ReadLine();

        }
    }
}
