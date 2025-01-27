﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20_Events_HW
{
    internal class PassengerCar : Car
    {
        public PassengerCar(string name = "Passenger Car", int speed = 100, int min_straight_speed = 90, int max_straight_speed = 120, int min_turning_speed = 65, int max_turning_speed = 75)
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
