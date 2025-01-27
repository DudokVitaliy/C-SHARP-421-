using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Events_HW
{
    internal class Game
    {
        private Car[] Cars;
        private double[] time = new double[4];
        public Game()
        {
            Cars = new Car[4];
            Cars[0] = new SportCar();
            Cars[1] = new PassengerCar();
            Cars[2] = new Truck();
            Cars[3] = new Bus();
        }
        public void Star()
        {
            foreach (var item in Cars)
            {
                item.Start();
            }
        }
        public void ShowTime()
        {
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine($"{Cars[i].Name} :: {time[i]}s");
            }
        }
        public void Race()
        {
            // траса довжиною 100 км, поділимо на відрізки прямих і повороти
            
            Console.WriteLine("First stage:");
            for (int i = 0; i < 4; i++)
            {
                time [i] = (10/Cars[i].Speed) * 3600;
            }
            ShowTime();
            Console.WriteLine("First turn:");
            for (int i = 0; i < 4; i++)
            {
                Cars[i].Speed = Car.ChangeSpeed(Cars[i].Min_turning_speed, Cars[i].Max_turning_speed);
            }
            for (int i = 0; i < 4; i++)
            {
                time[i] += 0.5 / Cars[i].Speed;
            }
            ShowTime();
            Console.WriteLine("Stage 2:");
            for(int i = 0;i < 4; i++)
            {
                Cars[i].Speed = Car.ChangeSpeed(Cars[i].Min_straight_speed, Cars[i].Max_straight_speed);
            }
            for (int i = 0; i < 4; i++)
            {
                time[i] += 30 / Cars[i].Speed;
            }
            Console.WriteLine("Turn 2:");
            for (int i = 0; i < 4; i++)
            {
                Cars[i].Speed = Car.ChangeSpeed(Cars[i].Min_turning_speed, Cars[i].Max_turning_speed);
            }
            for (int i = 0; i < 4; i++)
            {
                time[i] += 1.5 / Cars[i].Speed;
            }
            Console.WriteLine("Stage 3:");
            for (int i = 0; i < 4; i++)
            {
                Cars[i].Speed = Car.ChangeSpeed(Cars[i].Min_straight_speed, Cars[i].Max_straight_speed);
            }
            for (int i = 0; i < 4; i++)
            {
                time[i] += 15 / Cars[i].Speed;
            }
            Console.WriteLine("Turn 2:");
            for (int i = 0; i < 4; i++)
            {
                Cars[i].Speed = Car.ChangeSpeed(Cars[i].Min_turning_speed, Cars[i].Max_turning_speed);
            }
            for (int i = 0; i < 4; i++)
            {
                time[i] += 3 / Cars[i].Speed;
            }


        }

    }
}
