using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _1_Product : _1_Money
    {
        public string Name { get; set; } = "empty";
        public _1_Product(string name = "empty", int dol = 0, int cen = 0)
            :base(dol, cen)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"name\t: {Name, -15} price: " + base.ToString();
        }
        public void ChangePrice(double value)
        {
            int old_price = Dollar * 100 + Cent;
            int change = (int)(value * 100);
            int new_price = old_price + change;
            if (new_price < 0)
            {
                Dollar = 0; Cent = 0;
            }
            else
            {
                Dollar = new_price / 100;
                Cent = new_price % 100;
            }

        }
    }
}
