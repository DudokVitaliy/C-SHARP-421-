using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _2_Car : _2_Device
    {
        public string Fuel { get; set; }
        public _2_Car(string name = "empty", string brand = "empty", string color = "empty", string fuel = "empty")
            : base(name, brand, color)
        {
            Fuel = fuel;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Fuel:: {Fuel}");
        }
        public override void Sound()
        {
            Console.WriteLine("This sound of CAR!");
        }
        public override void Desc()
        {
            Console.WriteLine("\tCar Description:\nCars save lots of energy and time. They reduce the cost and time of commuting to work. That's why people willingly spend money on cars and their maintenance. As a result, automobile industry is constantly developing and flourishing.");
        }
    }
}
