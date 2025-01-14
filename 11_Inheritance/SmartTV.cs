﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Inheritance
{
    internal class SmartTV : TV
    {
        public bool HasInternet { get => true; }
        public SmartTV(string brand = "no_brand", int year = 2000, int diagonal = 42)
            :base(brand, year, diagonal)
        { }
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Internet :: {HasInternet}");
        }
            
    }
    
}
