using System.Diagnostics;

namespace _21_Events_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game race = new Game();

            race.AddCar(new SportCar("SportCar"));
            race.AddCar(new Sedan("Sedan"));
            race.AddCar(new Truck("Truck"));
            race.AddCar(new Bus("Bus"));

            race.StartRace();
        }
    }
}
