namespace _17_Delegate
{
    // визначення типу делегату, делегат - тип(компілятор створить клас), який в собі має посилання на метод певної сигнатури)
    delegate void MsgDelegate(string message); // може бути як статичнив так і не статичним; void  - метод з параметром типу string
    static class Gretting
    {
        public static void Hello(string name) // метод підходить до ледегата MsgDelegate
        {
            Console.WriteLine($"Hello, {name}");
        }
        public static void Bye(string name) // метод підходить до ледегата MsgDelegate
        {
            Console.WriteLine($"Bye, {name}");
        }
        public static void HowAreYou(string name) // метод підходить до ледегата MsgDelegate
        {
            Console.WriteLine($"How are you, {name}"); 
        }
        public static void HowAreYou(string name, string surname) // метод не підходить до ледегата MsgDelegate
        {
            Console.WriteLine($"How are you, {name} {surname}");
        }
        public static void DrawLine(int len, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n{new string('*', len)}");
            Console.ResetColor();
        }
    }
    delegate double CalcDelegate (double one, double two);
    class Calculate
    {
        public static double Add(double x, double y) => x + y;
        public static double Sub(double x, double y) => x - y;
        public double Mult(double x, double y) => x * y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gretting.DrawLine(50, ConsoleColor.Red);
            Gretting.Hello("Ivan"); // явний виклик статичного методу (Invoke)

            Gretting.DrawLine(50, ConsoleColor.Green);
            MsgDelegate del = new MsgDelegate(Gretting.Hello);
            del.Invoke("Maria");
            del("Vitaliy");

            Console.WriteLine($"___________ Del references to method : {del.Method}");
            Console.WriteLine($"___________ Del target to object : {del.Target}");

            Gretting.DrawLine(50, ConsoleColor.Green);
            del = Gretting.HowAreYou;
            Console.WriteLine($"___________ Del references to method : {del.Method}");
            del("Sasha");

            // MultyCastDelegate - один містить декілька методів
            MsgDelegate group = new MsgDelegate(Gretting.Hello) + Gretting.HowAreYou; // щоб додати ще один метод
            group += Gretting.HowAreYou;
            group += Gretting.Bye;
            Gretting.DrawLine(50, ConsoleColor.Green);
            group("Olga"); // викличуться всі додані

            group -= Gretting.HowAreYou;
            Gretting.DrawLine(50, ConsoleColor.Green);
            group("Olga");

            Gretting.DrawLine(50, ConsoleColor.Green);
            Console.WriteLine("\t\tCalculate:");
            CalcDelegate calc = Calculate.Add;
            Console.WriteLine($"Method :: {calc.Method}");
            Console.WriteLine($"Target :: {calc.Target}");
            Console.WriteLine($"Resalt :: {calc(2,3)}");

            Gretting.DrawLine(50, ConsoleColor.Green);

            calc += Calculate.Sub;
            Console.WriteLine($"Method :: {calc.Method}");
            Console.WriteLine($"Target :: {calc.Target}");
            Console.WriteLine($"Resalt :: {calc(2, 3)}"); // побачимо результат останнього

            Gretting.DrawLine(50, ConsoleColor.Blue);
            foreach (var item in calc.GetInvocationList()) //щоб перетворити в масив
            {
                Console.WriteLine($"Operation: {item.Method.Name} :: {item.DynamicInvoke(10, 15)}");
            }

            Gretting.DrawLine(50, ConsoleColor.Blue);
            Calculate calculate = new Calculate();
            calc = calculate.Mult;
            Console.WriteLine($"Method :: {calc.Method}");
            Console.WriteLine($"Target :: {calc.Target}");
            Console.WriteLine($"Resalt :: {calc(2, 3)}");

        }
    }
}
