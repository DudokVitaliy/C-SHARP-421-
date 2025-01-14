using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal class _4_Engineer : _4_Worker
    {
        public bool PossibilityOfBusinessTrips { get; set; }
        public _4_Engineer(string name = "empty", double salary = 0, int workExperience = 0, DateTime? birth = null, bool possibilityOfBusinessTrips = false)
            : base(name, salary, workExperience, birth)
        {
            PossibilityOfBusinessTrips = possibilityOfBusinessTrips;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"possibility of business trips: {PossibilityOfBusinessTrips,-15} ");
        }
    }
}
