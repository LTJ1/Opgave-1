using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11
{
    public class Terning
    {
        private int værdi;
        private static System.Random rnd;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning aflæses som " + this.værdi);
                return this.værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                    value = 1;
                Console.WriteLine("Terning tildeles " + value );
                this.værdi = value;
            }

        }


        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }
        public Terning()
        {
            this.Ryst();
        }
        static Terning()
        {
            rnd = new Random();
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);

        } 

    }
}
