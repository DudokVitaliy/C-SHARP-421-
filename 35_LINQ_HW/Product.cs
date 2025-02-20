using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_LINQ_HW
{
    class Category
    {
        public string Name { get; set; }
    }
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string CountryOfOrigin { get; set; }
        public Category Category { get; set; }
    }
}
