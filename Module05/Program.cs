using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(5, 2);
            Console.WriteLine(res); // Returnerer 7

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // Returnerer 78,53

            Udskriv();             // Blank linie

            Udskriv("Dette er en test"); // Udskriv texten(Dette er en test)

            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);

            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res4);

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);
        }

        static double BeregnAreal(double radius)
        {
            return radius * radius * 3.1415;
        } 
        static int LægSammen(int a, int b)
        {
           return a + b; 
        }
        static void Udskriv()
        {
            Console.WriteLine();
        }
        static void Udskriv(string text)
        {
            Console.WriteLine(text);
        }
        static double BeregnMoms(double tal, double Momspct = 0.25)
        {
            return tal * Momspct;
        }
        static double Gennemsnit(int[] løn)
        {
            double sum = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                sum += løn[i];
            }
            double g = sum / løn.Length;
            return g;
        }
    }

}
