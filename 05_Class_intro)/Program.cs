namespace _05_Class_intro_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Characters characters = new Characters("Elf", 100, 10);
            characters.Print();
            Console.WriteLine(characters.ToString());
            Characters characters1 = new Characters(damage:15, name:"Mag", hp:150);
            //characters1.Print();
            Console.WriteLine(characters1.ToString());
            Characters characters2 = new Characters() { Name = "Ranger", Damage = 10, Hp = 100 };
            Console.WriteLine(characters2);
        }
    }
}
