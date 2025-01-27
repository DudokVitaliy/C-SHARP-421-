using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Events_HW
{
    internal class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Position { get; set; }
        public int MinSpeed { get; set; }
        public int MaxSpeed { get; set; }

        public event Action<Car> Finish;

        public Car(string name, int minSpeed, int maxSpeed)
        {
            Name = name;
            MinSpeed = minSpeed;
            MaxSpeed = maxSpeed;
            Position = 0;
        }

        public void Drive()
        {
            Speed = new Random().Next(MinSpeed, MaxSpeed + 1);
            Position += Speed;

            if (Position >= 100)
            {
                Position = 100;
                Finish?.Invoke(this);
            }
        }

        public override string ToString()
        {
            return $"{Name}: Speed = {Speed}, Position = {Position}%";
        }
    }
}
