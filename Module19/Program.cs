using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bunke med kort indeholder Spar 2, Hjerter 14 og Ruder 10 
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 10 });
            b.Vis();

            // Ruder 10 fjernes fra bunken, der nu indeholder Spar 2 og Hjerter 14
            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            b.Vis();
        }

    }
}
