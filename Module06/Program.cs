using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06
{
    class Program
    {
        static void Main(string[] args)

        {
            Terning t1;
            t1 = new Terning();              
            Console.WriteLine(t1.Værdi);     // t1 = 1

            Terning t2;
            t2 = new Terning(4);
            Console.WriteLine(t2.Værdi);    // t2 = 4 

            t2 = t1;
            Console.WriteLine(t1.Værdi);    // t1 = 1
            Console.WriteLine(t2.Værdi);    // t2 = 1

            t1.Værdi = 3;
            Console.WriteLine(t1.Værdi);   // t1 = 3
            Console.WriteLine(t2.Værdi);   // t2 = 3

            t2.Værdi = 5;
            Console.WriteLine(t1.Værdi);   // t1 = 5
            Console.WriteLine(t2.Værdi);   // t2 = 5

        }
    }
}
