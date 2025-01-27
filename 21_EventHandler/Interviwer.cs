using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EventHandler
{
    internal class Interviwer
    {
        public string Name { get; set; }
        public void DoSomething(object sender, MyArgs args)
        {
            Console.WriteLine($"Interviwer {Name} notified about {args.Description} \n\tDate:: {args.Date} \n\tfrom company:: {args.CompanyName}");
        }
    }
}
