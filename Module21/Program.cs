using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true; w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            // Udskriver ved ændring af en fil i c:emp 
            w.Changed += W_changed;
            do { } while (true);
        }
        private static void W_changed(Object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen er rettet " + e.Name);
        }
    }
}
