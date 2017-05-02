using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave03
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] månedsløn = { 1000, 7000, 9000, 3000, 8000, 6000, 7000, 4000, 99000, 10000, 11000, 12000 };
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            Double gns = sum / månedsløn.Length;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));

            Array.Sort(månedsløn);

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }

            Console.ReadKey();
        }
        
    }
}
