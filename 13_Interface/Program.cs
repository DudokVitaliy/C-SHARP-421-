namespace _13_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck() { Weight = 100 };
            duck.Fly();
            duck.Move();
            duck.Swim();
            Console.WriteLine();

            Console.WriteLine("---------- Duck Fly -------------");
            IFly fly = duck;
            fly.Fly();
            Console.WriteLine(fly.Speed);

            Console.WriteLine("---------- Duck Move -------------");
            IMove move = duck;
            move.Move();
            Console.WriteLine(move.Speed);

            Console.WriteLine("---------- Streamer Duck Move -------------");
            StreamerDuck streamerDuck = new StreamerDuck();
            streamerDuck.Fly();

            IFly[] ducks = { duck, streamerDuck };
            foreach (var d in ducks)
            {
                Console.WriteLine($"{d.Speed}");
                duck.Fly();
            }
        }
    }
}
