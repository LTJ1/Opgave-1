using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant t1 = new Trekant(14,4);

            double areal = t1.Areal;
            Console.WriteLine(areal);
            Console.ReadKey();    

        }
    }
}
