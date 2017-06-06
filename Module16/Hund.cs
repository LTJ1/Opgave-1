using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16
{
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer hund");
        }
    }
}
