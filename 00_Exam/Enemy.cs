using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _00_Exam
{
    [JsonPolymorphic]
    [JsonDerivedType(typeof(Monster), "monster")]
    [JsonDerivedType(typeof(Boss), "boss")]
    internal abstract class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Award { get; set; }
        public Enemy(string name, int health, int power, int award)
        {
            Name = name;
            Health = health;
            Power = power;
            Award = award;
        }
        public Enemy() { }
        public override string ToString()
        {
            return $"Monster: {Name,-10}Health: {Health,-3}HP      Power: {Power}";
        }

    }
}
