using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace _00_Exam
{
    enum ResourceList
    {
        Diamonds = 10,
        Gold = 5,
        Wood = 1
    }

    internal class Hero
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
        public int Defense { get; set; }
        public int Balance { get; set; }
        [JsonConstructor]
        public Hero(string name, int power, int health)
        {
            Name = name;
            Power = power;
            Health = health;
            Defense = 0;
            Balance = 0;
        }
        public Hero() { }
        public void ExtractResources()
        {
            Array values = Enum.GetValues(typeof(ResourceList));
            ResourceList randomResource = (ResourceList)values.GetValue(new Random().Next(values.Length));
            Console.WriteLine($"\tYou were lucky to find {randomResource}!");
            Balance += (int)randomResource;
        }
        //public void BuyBalance() - в майбутньому функція донату
        //{}
        public bool Fight(Enemy enemy)
        {
            if (enemy is Monster)
            {
                Monster monster = (Monster)enemy;
                Console.WriteLine($"\tFight with monster {enemy.Name}");
                Thread.Sleep(2000);
                int i = 0;
                Console.WriteLine(this);
                Console.WriteLine(monster);
                while (monster.Health > 0 && this.Health > 0)
                {
                    Console.WriteLine($"\tRound {++i}");
                    Health -= (monster.Power - Defense);
                    monster.Health -= this.Power;
                    Console.WriteLine(this);
                    Console.WriteLine(monster);
                    Thread.Sleep(2000);
                }
                Balance += monster.Award;
                if (this.Health > 0)
                {
                    return true;
                }
                else { return false; }
            }
            else if(enemy is Boss)
            {
                Boss boss = (Boss)enemy;
                Console.WriteLine($"\tFight with Boss {enemy.Name}");
                Thread.Sleep(2000);
                int i = 0;
                Console.WriteLine(this);
                Console.WriteLine(boss);
                while (boss.Health > 0 && this.Health > 0)
                {
                    Console.WriteLine($"\tRound {++i}");
                    Health -= (boss.Power + boss.SpecialAttack - Defense);
                    boss.Health -= this.Power;
                    Console.WriteLine(this);
                    Console.WriteLine(boss);
                    Thread.Sleep(2000);
                }
                Balance += boss.Award;
                if (this.Health > 0)
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }
        public void GoShop()
        {
            Shop.GoShop(this);
        }
        public override string ToString()
        {
            return $"Hero:    {Name,-10}Health: {Health, -3}HP      Power: {Power,-10}Defense: {Defense,-10}Ballance: {Balance, -10}";
        }

    }
    
}