using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class Smartphone : Device
    {
        public bool HasBatery { get; set; } = true;
        public Smartphone(string brand = "no_brand", int year = 2000, bool hasBatery = true)
            :base(brand, year)
        {
            HasBatery = hasBatery;
        }
        public override void Print()
        {
            //base.Print();
            Console.WriteLine($"{this.GetType().Name,-10} Brand :: {brand,-10}Year :: {Year,-10}Weight :: {Weight,-10}" +
                $"Price :: {Price,-10}HasBatery :: {HasBatery,-10} ");

        }
        public void Call()
        {
            Console.WriteLine($"\n{new string('#', 50)}\n\tCall!\n{new string('#', 50)}");
        }
    }
}
