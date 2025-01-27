using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events_HW
{
    internal class Truck : Car
    {
        public Truck(string name = "Truck", int speed = 80, int min_straight_speed = 75, int max_straight_speed = 100, int min_turning_speed = 50, int max_turning_speed = 55)
            : base(name, speed, min_straight_speed, max_straight_speed, min_turning_speed, max_turning_speed) { }

        public override void Start()
        {
            Console.WriteLine($"{Name} - start drive with speed {Speed} km/h");
        }

        public override void Finish()
        {
            Console.WriteLine($"{Name} - finished");
        }
    }
}
