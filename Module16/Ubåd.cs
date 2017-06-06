using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16
{
    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd");
        }
    }
}
