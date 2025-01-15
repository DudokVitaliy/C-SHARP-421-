namespace _14_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // Enurable - те де ми проходимось
            //    // Enumerator - те чим ми проходимось 
            //    int[] arr = { 1, 2, 5, 9, 11, 23, 0 };
            //    var enAr = arr.GetEnumerator();
            //    while (enAr.MoveNext()) // чи є наступне значення
            //    {
            //        Console.Write($"{enAr.Current, -5}"); // повертає поточне значення
            //    }
            //    Console.WriteLine();

            Shop shop = new Shop();
            Item apple = new Item() { Name = "apple", Price = 30 };
            Item orange = new Item() { Name = "orange", Price = 40 };
            Item blueberry = new Item() { Name = "blueberry", Price = 45 };
            Item plum = new Item() { Name = "plum", Price = 70 };
            shop.AddItem(apple);
            shop.AddItem(orange);
            shop.AddItem(blueberry);
            shop.AddItem(plum);

            Console.WriteLine("---------- IEnumerable getEnumerator -----------");
            foreach (var item in shop)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------- IEnumerable GetReverse -----------");
            foreach (var item in shop.GetReverse())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------- IEnumerable GetLimitProduct -----------");
            foreach (var item in shop.GetLimitProduct(60))
            {
                Console.WriteLine(item);
            }
        }
        
        
    }
}
