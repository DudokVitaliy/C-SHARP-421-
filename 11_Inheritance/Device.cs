using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal abstract class Device
    {
        protected string brand;
        public string Brand { get => brand; set => brand = value ?? "no_brand"; }
        private int year;
        public int Year { get => year;
            set => year = value <= DateTime.Today.Year && value > 0 ? value : 2000; }
        public int Weight { get; set; }
        public int Price { get; set; }
        //public virtual void Print()
        //{
        //    Console.WriteLine($"{this.GetType().Name,-10} Brand :: {brand,-10}Year :: {year,-10}Weight :: {Weight,-10}Price :: {Price,-10} ");
        //}
        protected Device(string brand = "no_brand", int year = 2000)
        {
            Brand = brand;
            Year = year;
        }
        public abstract void Print();

    }
}
