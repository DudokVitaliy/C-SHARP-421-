using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _2_Kettle : _2_Device
    {
        public double Volume { get; set; } = 0;
        public double Power { get; set; } = 0;
        public _2_Kettle(string name = "empty", string brand = "empty", string color = "empty", double volume = 0, double power = 0)
            :base(name, brand, color)
        {
            Volume = volume;
            Power = power;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Volume:: {Volume}L\t\tPower:: {Power}V ");
        }
        public override void Sound()
        {
            Console.WriteLine("This sound of KETTLE!");
        }
        public override void Desc()
        {
            Console.WriteLine("\tKettle Description:\nThe working principle of the electric kettle is that the water vapor generated during boiling water deforms the bimetallic sheet of the steam temperature sensing element, and this deformation presses the power switch to cut off the power according to the lever principle. The power failure is not self-recovery, so the kettle will not heat up automatically after the power failure.");
        }

    }
}
