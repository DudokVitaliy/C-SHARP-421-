internal class Program
{
    static void InputSymb()
    {
        Console.WriteLine("Enter one symbol : ");
        char symbol = (char)Console.Read();
        Console.WriteLine("Symbol :: "+ symbol);
        Console.WriteLine("IsLetter :: " + char.IsLetter(symbol));
        Console.WriteLine("IsUpper :: " + char.IsUpper(symbol));
        Console.WriteLine("IsDigit :: " + char.IsDigit(symbol));
    }

    private static void Main(string[] args)
    {
        //InputSymb();
        //Task();
        //Console.WriteLine("Enter Line :: ");
        //string text = Console.ReadLine();

        //double res = Convert.ToDouble(text);

        //var res = int.Parse(text);

        //int res;
        //if (int.TryParse(text, out res))
        //{
        //    res = res + 10;
        //    Console.WriteLine($"Result = {res}");
        //}

        //Console.WriteLine("Enter number of day :: ");
        //int day = int.Parse(Console.ReadLine());

        ////if (day == 1)
        ////{
        ////    Console.WriteLine("Monday");
        ////}
        ////else if (day == 2)
        ////{
        ////    Console.WriteLine("Tuersday");
        ////}
        ////else
        ////{
        ////    Console.WriteLine("Error");
        ////}
        //switch (day)
        //{
        //    case 1:
        //        Console.WriteLine("Monday");
        //        break;
        //    case 2:
        //        Console.WriteLine("Tuersday");
        //        break;
        //    default:
        //        Console.WriteLine("Error");
        //        break;
        //}

        //int i = 0;
        //for (; ; )
        //{
        //    i++;
        //    Console.WriteLine(i + "Hello");
        //    if (i >= 5) break;
        //}
        //ConsoleKey key;
        //while ((key = Console.ReadKey().Key) != ConsoleKey.Escape)
        //{
        //    switch (key)
        //    { 
        //        case ConsoleKey.UpArrow:
        //            Console.WriteLine("UpArrow");
        //            break;
        //        case ConsoleKey.DownArrow:
        //            Console.WriteLine("DownArrow");
        //            break;
        //        case ConsoleKey.LeftArrow:
        //            Console.WriteLine("LeftArrow");
        //            break;
        //        case ConsoleKey.RightArrow:
        //            Console.WriteLine("RightArrow");
        //            break;
        //        default:
        //            break;

        //    }
        //}
        int res;
        do
        {
            Console.WriteLine("2 + 2 = ");
            res = int.Parse(Console.ReadLine());
        } while (res != 4);



    }
    static void Task()
    {
        //Console.BackgroundColor = ConsoleColor.Green;
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.CursorLeft = 40;
        //Console.CursorTop = 40;
        Console.OutputEncoding = System.Text.Encoding.Unicode; // вивід кирилиці
        Console.InputEncoding = System.Text.Encoding.Unicode; // ввід кирилиці
        string line = "C# language - популярна мова під .NET";
        string str = "Hello!!!";
        Console.WriteLine(line);
        double d = 23.224353;
        decimal money = 123_456_890_123m;
        float f = 189.34f;
        var v = 777.888;

        // 1) write
        Console.WriteLine("Money = " + money);

        // 2) format line
        Console.WriteLine("Float value f = {0} /t SQRT = {1}", f, Math.Sqrt(f));

        // 3) imterplation line
        Console.WriteLine($"Message :: {str}");
        Console.WriteLine($"Value v * 2 = {v * 2,-20}  ++ f = {++f}");
    }
}