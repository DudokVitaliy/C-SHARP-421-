namespace _16_Structure_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //City city = new City();
            //Console.WriteLine(city);
            City rivne = new City("Rivne", 240_451);
            //Console.WriteLine(rivne);

            //City clone = rivne; // поверхневе копіювання
            //Console.WriteLine();
            //Console.WriteLine("Origin: "+rivne);
            //Console.WriteLine("Clone:  "+clone);
            //clone.Name = "Rivne-2";
            //clone.Population = 777_777;
            //Console.WriteLine("Origin: " + rivne);
            //Console.WriteLine("Clone:  " + clone);

            int value = 42, value2 = 123;
            int[] arr = { -4, 3, 2, 9, -7, 11, 5 };
            Console.WriteLine(String.Join<int>(", ", arr));
            Array.Sort(arr);
            Console.WriteLine(String.Join<int>(", ", arr));
            // 1 - ">"; -1 - "<"; 0 - "=";
            Console.WriteLine(value.CompareTo(value2)); // -1
            Console.WriteLine(value2.CompareTo(value)); // 1
            value = 123;
            Console.WriteLine(value.CompareTo(value)); // 0
            City[] cityes =
                {
                rivne,
                new City("Kyiv", 2952_000),
                new City("Poltava", 272_572),
                new City("Lviv", 710_572)
                };
            //Array.Sort(cityes,(a,b) => a.Population.CompareTo(b.Population));
            Array.Sort(cityes); // від меншого до більшого по population
            foreach (City city in cityes)
                Console.WriteLine($"City: {city}");
            Console.WriteLine();

            Array.Sort(cityes, new SortByName());
            foreach (City city in cityes)
                Console.WriteLine($"City: {city}");
            Console.WriteLine();

            Array.Sort(cityes, new SortByNameDesc());
            foreach (City city in cityes)
                Console.WriteLine($"City: {city}");
            Console.WriteLine();
        }
    }
    struct SortByName : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
    struct SortByNameDesc : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return -x.Name.CompareTo(y.Name);
        }
    }
}
