using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Events_HW
{
    internal class Game
    {
        private readonly List<Car> _cars = new();
        private bool _raceFinished = false;

        public void AddCar(Car car)
        {
            car.Finish += FinishRace;
            _cars.Add(car);
        }

        public void StartRace()
        {
            Console.WriteLine("Start Race!");
            while (!_raceFinished)
            {
                foreach (var car in _cars)
                {
                    car.Drive();
                    Console.WriteLine(car);
                }
                Console.WriteLine($"{new string ('*', 50)}");
            }
        }

        private void FinishRace(Car car)
        {
            _raceFinished = true;
            Console.WriteLine($"\nWinner: {car.Name}!");
        }
    }
}
