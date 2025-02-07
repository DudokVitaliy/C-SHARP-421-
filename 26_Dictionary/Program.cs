namespace _26_Dictionary
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>()
            {
                ["hello"] = "привіт",
                ["bye"] = "бувай",
                ["cat"] = "кіт",
                ["program"] = "програма",
                ["developer"] = "розробник"
            };
            Console.OutputEncoding = Encoding.UTF8;
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key,-10} {item.Value}");
            }
            SortedDictionary<string, string> sortDic = new SortedDictionary<string, string>(dic);
            Console.WriteLine("Sorted");
            foreach (var item in sortDic)
            {
                Console.WriteLine($"{item.Key,-10} {item.Value}");
            }
        }
    }
}
