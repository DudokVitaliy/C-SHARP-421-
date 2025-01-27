using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events_HW
{
    internal class SportCar : Car
    {

        public SportCar(string name = "Sportcar", int speed = 120, int min_straight_speed = 110, int max_straight_speed = 140, int min_turning_speed = 70, int max_turning_speed = 80)
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
