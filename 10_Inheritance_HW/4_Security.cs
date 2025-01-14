using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _4_Security : _4_Worker
    {
        public bool MilitaryExperience { get; set; }
        public _4_Security(string name = "empty", double salary = 0, int workExperience = 0, DateTime? birth = null, bool militaryExperience = false)
            : base(name, salary, workExperience, birth)
        {
            MilitaryExperience = militaryExperience;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"military experience: {MilitaryExperience,-15} ");
        }
    }
}
