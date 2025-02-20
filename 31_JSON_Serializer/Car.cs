using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_JSON_Serializer
{
    public class Engine
    {
        public double Power { get; set; } //autoprop
        public Engine(double power)
        {
            Power = power;
        }
        public Engine() : this(1.0) { }
        public override string ToString()
        {
            return $"Engine power :: {Power}";
        }
    }
    public class Car
    {
        // [XmlAttribute("Number")] - атрибут
        // [XmlIgnore] - пропускає наступну властивість
        public int id;
        private string brand;
        public string Brand { get => brand; set => brand = value ?? "no brand"; }
        public Engine Engine { get; set; }
        public Car(int id, string brand, double power)
        {
            this.id = id;
            Brand = brand;
            Engine = new Engine(power);
        }
        public Car() : this(0, "no brand", 1.0) { }
        public override string ToString()
        {
            return $"ID :: {id}. Brand :: {Brand,-15}Engine :: {Engine}";
        }

    }
}
