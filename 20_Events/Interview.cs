using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events
{
    internal class Interviwer
    {
        public string Name { get; set; }
        // метод під делегат Position delegate
        public void DoSomething(string desc)
        {
            Console.WriteLine($"Interviwer {Name} notified about {desc}");
        }
    }
}
