namespace _34_LINQ_to_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -3, 4, 5, 6, -7, 8, -9 };
            /*
             IEnumerable <> res =   from item_name in collection 
                                    select item_name 
             */
            Print(arr, "Print origin: ");
            IEnumerable<int> query = from numb in arr
                                     select numb * -1; // відкладене завантаження
            // негайне завантаження
            //List<int> ints = query.ToList();

            Print(query, "Test select: ");

            query = arr.Select(ConvertData);
            Print(query, "Test select: ");

            query = arr.Select(delegate (int item) { return item * 2; });
            Print(query, "Test select: ");

            query = arr.Select(item => item / 2);
            Print(query, "Test select: ");

            // Where --> filter
            query = from numb in arr
                    where numb % 2 == 0
                    select numb;
            Print(query, "Test select: ");

            query = arr.Where(x => x % 2 != 0).Select(ConvertData);
            Print(query, "Test select: ");

            string[] colors = { "red", "pink", "green", "yellow", "blackandwhite", "lime", "gold", "violet", "orange" };
            var res = from c in colors
                      where c.Length == 4
                      select c;
            Print(res, "Test select: ");

            res = colors.Where(c => c.Length == 4);
            Print(res, "Test select: ");

            Console.WriteLine($"Max length: {colors.Max(x => x.Length)}");

            res = from c in colors
                  where c.Contains('a')
                  select c;
            Print(res, "Test select: ");


        }



        static int ConvertData(int value)
        {
            return (int)Math.Pow(value, 2);
        }
        static void Print<T>(IEnumerable<T> query, string text = "")
        {
            Console.WriteLine($"{(text.Length == 0 ? "" : "\n\t")}{text}");
            foreach (var i in query)
            {
                Console.WriteLine($"{i,-7}");
            }
            Console.WriteLine();
        }



    }
}