using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal abstract class _3_MusicInstrument
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public _3_MusicInstrument(string name = "empty", string manufacturer = "empty", string color = "empty")
        {
            Name = name;
            Manufacturer = manufacturer;
            Color = color;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name,-15} Manufacturer: {Manufacturer,-15} Color: {Color,-15}");
        }
        public abstract void Sound();
        public abstract void Desc();
        public abstract void History();
    } 
}
