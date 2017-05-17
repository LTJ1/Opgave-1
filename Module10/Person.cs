using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    class Person
    {
        
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string Fuldtnavn(){
            return $"{Fornavn} {Efternavn}";
        }       
    }
}
