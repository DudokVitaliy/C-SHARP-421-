using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _4_Manager : _4_Worker
    {
        public int ProjectCount { get; set; }
        public _4_Manager(string name = "empty", double salary = 0, int workExperience = 0, DateTime? birth = null, int projectCount = 0)
            : base(name, salary, workExperience, birth)
        {
            ProjectCount = projectCount;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"project count: {ProjectCount,-15} ");
        }
    }
}
