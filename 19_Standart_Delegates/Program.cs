namespace _19_Standart_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- ACTION --------------");
            Action action = () => { Console.WriteLine("Hello from std Delegates"); };
            action += Hello;
            action();

            Action <string, int> action1 = (str,numb) => Console.WriteLine($"{str} + {numb}");
            action1("test", 100);

            Console.WriteLine("--------------- FUNC --------------");
            Func<int, int, double> func = (one, two) => (one + two) / 2.0;
            Console.WriteLine($"Func avg --> {func(10, 11)}");

            Console.WriteLine("--------------- PREDICATE --------------");
            Predicate<string> pred = a => Char.IsUpper(a[0]);
            string wordA = "Program";
            string wordB = "python";
            Console.WriteLine($"Has first upper letter: {pred(wordA)}");
            Console.WriteLine($"Has first upper letter: {pred(wordB)}");

            Console.WriteLine("--------------- COMPARISON --------------");
            Comparison<string> cmp = (s1, s2) => s1.Length.CompareTo(s2.Length);
            Console.WriteLine(cmp(wordA, wordB)); // 1 бо перше слово довше
            Console.WriteLine(cmp(wordB, wordA)); // -1 бо перше слово менше


        }
        static void Hello()
        {
            Console.WriteLine("Hello Action");
        }
    }
}
