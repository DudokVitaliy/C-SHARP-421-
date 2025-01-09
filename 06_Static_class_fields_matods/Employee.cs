using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Static_class_fields_matods
{
    enum Position
    {
        None, Manager, QA, Developer, Economist, Director
    }
    internal class Employee
    {
        private static int lastId;
        public readonly int ID = ++lastId; // лише для читання, значення встановлюється 1 раз (в конструкторі або тут)
        public string Name { get; set; } = "NoName";
        public DateTime Birth {  get; set; }
        public Position Position { get; set; }
        public static int LastId { get => lastId; }
        public static bool SamePosition(Employee em1, Employee em2) => em1.Position == em2.Position;
        static Employee() // без параметрів запускається до того як буде викор клас
        {
            Console.WriteLine("\t\tStatic ctor done");
            lastId = new Random().Next(1,10) * 1000;
        }
        public override string ToString() => $"ID :: {ID,-5} Name :: {Name, -10} Birth :: {Birth.ToShortDateString(), -10} " +
            $"Position :: {Position, -10} Age :: {Age, -10}";
        public int Age => (int)((DateTime.Today - Birth).TotalDays / 365.25);
    }
}
