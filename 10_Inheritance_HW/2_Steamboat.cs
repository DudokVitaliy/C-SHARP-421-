using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _2_Steamboat : _2_Device
    {
        public double Shipload { get; set; } = 0;
        public _2_Steamboat(string name = "empty", string brand = "empty", string color = "empty", double shipload = 0)
            : base(name, brand, color)
        {
            Shipload = shipload;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Shipload:: {Shipload}ton");
        }
        public override void Sound()
        {
            Console.WriteLine("This sound of STEAMBOAT!");
        }
        public override void Desc()
        {
            Console.WriteLine("\tSteamboat Description:\nScrew steamships use a propeller as a propulsion system, driven through a shaft from a steam engine or steam turbine (the latter can also be a source of energy in a turbo-electric ship, a type of ship that is not a steamship in the strict sense of the word). Compared to a paddle wheel, a screw has a significant number of advantages.");
        }
    }
}
