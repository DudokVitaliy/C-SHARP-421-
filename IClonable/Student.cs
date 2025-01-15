using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClonable
{
    internal class Student : ICloneable
    {
        public string Name { get; set; }
        private int[] marks;
        public Student(string name = "noname", int numbmarks = 5)
        {
            Name = name;
            marks = new int[numbmarks];
        }
        public Student(string name, params int[] arr)
        {
            Name=name;
            marks = (int[])arr.Clone();
        }
        public override string ToString()
        {
            return $"name: {Name, -10} marks: {String.Join<int>(", ", marks)}";
        }

        public object Clone()
        {
            return new Student(Name, marks);
        }

        public int this[int index]
        {
            get => marks[index];
            set => marks[index] = value >= 0 && value <= 12 ?
                value :
                throw new ArgumentOutOfRangeException("Bad value");
        }
    }
}
