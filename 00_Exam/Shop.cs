using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Exam
{
    internal class Objects
    {
        public int Sword { get; set; }
        public int Shield { get; set; }
        public int StrengthPotion { get; set; }
        public int HealingPotion { get; set; }

        public Objects()
        {
            Sword = 20;
            Shield = 10;
            StrengthPotion = 5;
            HealingPotion = 5;
        }
    }

    internal class Shop
    {
        public static Objects objects = new Objects();
        static string sw = "Sword";
        static string sh = "Shield";

        public static void GoShop(Hero hero)
        {
            while (true) {
            Console.WriteLine("\t\tShop Menu");
            Console.WriteLine($"\t1 - {sw} = {objects.Sword}");
            Console.WriteLine($"\t2 - {sh} = {objects.Shield}");
            Console.WriteLine($"\t3 - Strength Potion = {objects.StrengthPotion}");
            Console.WriteLine($"\t4 - Healing Potion = {objects.HealingPotion}");
            Console.WriteLine("\t0 - Exit");
            Console.Write("\t -> "); int choise = int.Parse(Console.ReadLine());
                if (choise == 0) break;
                switch (choise)
                {
                    case 1:
                        if (objects.Sword > hero.Balance)
                        {
                            Console.WriteLine("\tNot enough resources!");
                        }
                        else
                        {
                            hero.Balance -= objects.Sword;
                            hero.Power += 10;
                            sw = "Upgrade Sword"; // - щоб не купляти кілька разів предмет ми його прокачуємо
                            objects.Sword += 5; // - кожного разу ціна росте


                        }
                        break;
                    case 2:
                        if (objects.Shield > hero.Balance)
                        {
                            Console.WriteLine("\tNot enough resources!");
                        }
                        else
                        {
                            hero.Balance -= objects.Shield;
                            hero.Defense += 5;
                            sh = "Upgrade Shield";
                            objects.Shield += 5;
                        }
                        break;
                    case 3:
                        if (objects.StrengthPotion > hero.Balance)
                        {
                            Console.WriteLine("\tNot enough resources!");
                        }
                        else
                        {
                            hero.Balance -= objects.StrengthPotion;
                            hero.Power += 3;
                            objects.StrengthPotion += 2;
                        }
                        break;
                    case 4:
                        if (objects.HealingPotion > hero.Balance)
                        {
                            Console.WriteLine("\tNot enough resources!");
                        }
                        else
                        {
                            hero.Balance -= objects.HealingPotion;
                            hero.Health += 10;
                            objects.HealingPotion += 2;
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine(hero);
            }
        }
    }
}
