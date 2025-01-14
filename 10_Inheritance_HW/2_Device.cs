using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal abstract class _2_Device
    {
        protected string name;
        protected string brand;
        protected string color;
        public string Name { get => name; set => name = value ?? "empty"; }
        public string Brand { get => brand; set => brand = value ?? "empty"; }
        public string Color { get => color; set => color = value ?? "empty"; }
        public _2_Device(string name = "empty", string brand = "empty", string color = "empty")
        {
            Name = name;
            Brand = brand;
            Color = color;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Name :: {Name,-15} Brand:: {Brand,-15} Color:: {Color,-15}");
        }
        public abstract void Sound();
        public abstract void Desc();

    }
}
