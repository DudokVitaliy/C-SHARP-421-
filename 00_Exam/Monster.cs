using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _00_Exam
{
    internal class Monster : Enemy
    {
        [JsonConstructor]
        public Monster(string name, int health, int power, int award) : base(name, health, power, award) { }
        public Monster() : base("", 0, 0, 0) { }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
