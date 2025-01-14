using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Inheritance_HW
{
    internal abstract class _4_Worker
    {
        protected string name;
        public string Name { get => name; set => name = value; }
        protected double salary;
        public double Salary { get => salary; set => salary = value; }
        protected int workExperience;
        public int WorkExperience { get => workExperience; set => workExperience = value; }
        protected DateTime birth;
        public DateTime Birth { get => birth; set => birth = value; }
        public _4_Worker(string name = "empty", double salary = 0, int workExperience = 0, DateTime? birth = null)
        {
            Name = name;
            Salary = salary;
            WorkExperience = workExperience;
            Birth = birth ?? new DateTime(2000, 1, 1);
        }
        public virtual void Print()
        {
            Console.WriteLine($"name: {Name,-15} salary: ${Salary,-15} work experience: {WorkExperience,-15} birthday: {Birth.ToShortDateString()}");
        }

    }
}
