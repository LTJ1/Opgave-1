using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] Array = new IDbFunktioner[4];
            Array[0] = new Hund();
            Array[1] = new Ubåd();
            Array[2] = new Hund();
            Array[3] = new Ubåd();

            foreach (var item in Array)
            {
                item.Gem();
            }

        }
    }
}
