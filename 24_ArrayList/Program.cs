namespace _24_ArrayList
{
    using System.Collections;
    using System.Runtime.Intrinsics.Arm;

    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 41, 2.5, "test", true, ConsoleColor.Red };
            PrintList(list);
            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count   : {list.Count}");
            list.Add("lorem");
            list.AddRange(new int[] { 1, 2, 3 });
            PrintList(list,"After add:");
            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count   : {list.Count}");

            list.Remove("test");
            list.RemoveAt(0);
            PrintList(list, "After remove:");
            list.RemoveRange(2, 2);
            PrintList(list, "After remove renge:");

            list.Insert(2, "orange");
            list.InsertRange(5, new string[] { "one", "two" });
            PrintList(list, "After insert:");
            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count   : {list.Count}");

            list.Clear();
            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count   : {list.Count}");

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(40, 90));
            }
            PrintList(list);
            Console.WriteLine($"Capacity: {list.Capacity}");
            Console.WriteLine($"Count   : {list.Count}");
            list.Sort();
            PrintList(list, "sorted");
            Console.Clear();

            List<string> color = new List<string>()
            {
                "red", "green", "purple", "yellow", "gold", "magenta"
            };
            PrintList(color);
            color.InsertRange(4, new string[] { "cyan", "pink", "brow" });
            PrintList(color, "after insert");
            //color.RemoveAll(x => x.Contains('o'));
            //PrintList(color, "after remove");
            color.Sort();
            PrintList(color, "after sort");
            color.Sort((s1,s2) => s1.Length.CompareTo(s2.Length));
            PrintList(color, "after sort");

        }

        static void PrintList(IEnumerable list, string text = "")
        {
            Console.WriteLine(text);
            foreach (var item in list)
                Console.Write($"{item,-10}");
            Console.WriteLine();
        }
    }
}
