using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            int helTal = 10;
            // Læg 1 til heltal
            helTal++;
            // Træk 1 fra heltal
            helTal--;
            helTal += 20;
            // Udskriv heltal = 30
            Console.WriteLine(helTal);

            // Kommatal
            double kommatal = 12.5;

            // Læg 1 til
            kommatal++;
            // Træk 1 fra
            kommatal--;
            //Gange med 2
            kommatal *= 2;
            //Udskriv kommatal = 25
            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.cvs;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            //Dato sættes til dags dato
            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyyyy"));
            Console.WriteLine(dato.ToString("dmy"));

            Person p;
            p.id = 1;
            p.Navn = "Mikkel";

            // Udskriv navnet på p
            Console.WriteLine(p.Navn);


            Console.ReadKey();
        }

        public enum FilTyper
        {
            cvs,
            pdf,
            txt
        }

        public struct Person
        {
            public int id;
            public string Navn;
        }

    }
}
