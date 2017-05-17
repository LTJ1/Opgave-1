using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() {Efternavn = "Person Efternavn", Fornavn = "Person Fornavn" };
            Person e = new Elev() { Efternavn = "Elev Efternavn", Fornavn = "Elev Fornavn", KlasseLokale = "Lokale 314" };
            Person i = new Instruktør() { Efternavn = "Instruktør Efternavn", Fornavn = "Instruktør Fornavn", NøgleId = 1 };

            p.Skriv();
            e.Skriv();
            i.Skriv();

            Person[] lst = new Person[3];
            lst[0] = p; //Objekt af Person
            lst[1] = e; //Objekt af Elev
            lst[2] = i; //Objekt af Instruktør
            foreach (var item in lst)
                item.Skriv();
        }
    }
}
