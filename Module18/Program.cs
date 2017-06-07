using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst1 = new List<Person>();
            lst1.Add(new Person() { ID = 1, Navn = "Lukas" });
            lst1.Add(new Person() { ID = 2, Navn = "Magnus" });
            lst1.Add(new Person() { ID = 3, Navn = "John" });

            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> lst2 = new Dictionary<int, Person>();
            lst2.Add(1, new Person() { ID = 1, Navn = "Mette" });
            lst2.Add(2, new Person() { ID = 2, Navn = "Sif" });
            lst2.Add(3, new Person() { ID = 3, Navn = "Jytte" });
            var p = lst2[3];
            Console.WriteLine(p.Navn);
               
        }
    }
}
