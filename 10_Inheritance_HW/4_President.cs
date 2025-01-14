using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10_Inheritance_HW
{
    internal class _4_President : _4_Worker
    {
        public int Personnel { get; set; }
        public _4_President(string name = "empty", double salary = 0, int workExperience = 0, DateTime? birth = null, int personnel = 0)
            :base(name, salary, workExperience, birth)
        {
            Personnel = personnel;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"personnel: {Personnel,-15} ");
        }
    }
}
