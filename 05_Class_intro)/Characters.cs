using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class_intro_
{
    // public - видимий для всіх
    // iternal - закритий для інших
    internal class Characters // неявне успадкування від класу object
    {
        private string name = "no name";
        private uint hp = 100;
        public string Name
        {
            //get {
            //    return name;
            //}
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value)) // не порожній і не пробіли
                {
                    name = value;
                }
                else
                {
                    name = "test";
                };
            }
        }
        public uint Damage { get; set; } // prop = авто проперті
        public Characters(string name, uint hp, uint damage)
        {
            Name = name;
            this.hp = hp;
            Damage = damage;
        }
        public Characters(string name = "none") : this(name,100,5)
        {}
        public void Print()
        {
            Console.WriteLine($"Character name\t\t:: {Name}");
            Console.WriteLine($"Character hp\t\t:: {hp}");
            Console.WriteLine($"Character damage\t:: {Damage}");
        }
        public uint KPD { get=> Damage *  hp; }
        public override string ToString()
        {
            return $"Name :: {Name,-10} HP :: {hp,-10} Damage :: {Damage,-10} KPD :: {KPD,-10}";
        }
        public  uint Hp { get; set; }
    }
}
