using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _00_Exam
{
    internal class Boss : Enemy
    {
        public int SpecialAttack { get; set; }
        [JsonConstructor]
        public Boss(string name, int health, int power, int award, int specialattack) : base(name, health, power, award)
        {
            SpecialAttack = specialattack;
        }
        public Boss() : base("", 0, 0, 0) { }
        public override string ToString()
        {
            return $"Boss: {Name,-10}Health: {Health,-3}HP      Power: {Power,-10}Special Attack: {SpecialAttack}";
        }
    }
}
