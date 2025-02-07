namespace _25_SortedList
{
    using System.Collections;
    internal class Program
    {
        static void DemoSortedList()
        {
            System.Collections.SortedList list = new System.Collections.SortedList()
            {
                {10, "ten" },
                {5, "five" },
                {3, "three" },
                {7, "seven" },
                {2, "two" },
                {0, "zero" }
            };
            PrintList(list, "Print SortedList");
            list.Add(11, "eleven");
            list[7] = "SEVEN";
            PrintList(list, "Print SortedList");
            int key = 9;
            Console.WriteLine($"{key} ==> {list[key] ?? "NULL"}");
            if (!list.ContainsKey(key))
            {
                list.Add(key, "nine");
            }
            PrintList(list, "Print SortedList");
            key = 0;
            int index = 0;
            if(index < list.Count)
            {
                list.Remove(key);
            }
            PrintList(list, "Print SortedList");

        }
        static void SortedListGen()
        {
            SortedList<int, string> list = new SortedList<int, string>()
            {
                [1000] = "Pavlo",
                [555] = "Olya",
                [777] = "Dmytro"
            };
            PrintList(list, "SortedList");
            list.TryAdd(123, "test");
            //list.Add(1000, "Ivan");
            int id = 555;
            if(list.TryGetValue(id, out string name))
            {
                Console.WriteLine($"Get name by id {id} :: {name}");
            }
            list.RemoveAt(0);
            foreach (var item in list.Keys)
            {
                Console.WriteLine($"code : {item} - {list[item]}");
            }




        }
        static void PrintList(IDictionary list, string text = "")
        {
            Console.WriteLine($"\n\t" + text);
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key, -10} {item.Value}");
            }
        }
        static void Main(string[] args)
        {
            //DemoSortedList();
            SortedListGen();
        }
    }
}
