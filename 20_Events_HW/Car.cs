using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events_HW
{
    internal abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }

        public int Min_straight_speed { get; set; }
        public int Max_straight_speed { get; set; }
        public int Min_turning_speed { get; set; }
        public int Max_turning_speed { get; set; }

        public event Action<Car> OnFinish;
        public Car(string name, int speed, int min_straight_speed, int max_straight_speed, int min_turning_speed, int max_turning_speed)
        {
            Name = name;
            Speed = speed;
            Min_straight_speed = min_straight_speed;
            Max_straight_speed= max_straight_speed;
            Min_turning_speed = min_turning_speed;
            Max_turning_speed= max_turning_speed;
        }

        public static int ChangeSpeed(int min_speed, int max_speed )
        {
            int CurrentSpeed = new Random().Next(min_speed, max_speed + 1);
            return CurrentSpeed;
        }
        public abstract void Start();
        public abstract void Finish();
        
    }
}
