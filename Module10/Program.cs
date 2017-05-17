using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() { Efternavn = "Jørgensen", Fornavn = "Lotte" };
            Elev e = new Elev() { Efternavn = "Bak Jørgensen", Fornavn = "Magnus", KlasseLokale = "A" };
            Instruktør i = new Instruktør() { Efternavn = "Bak", Fornavn = "John", NøgleId = 1 };
            Console.WriteLine(p.Fuldtnavn());
            Console.WriteLine(e.Fuldtnavn());
            Console.WriteLine(i.Fuldtnavn());
        }
    }
}
