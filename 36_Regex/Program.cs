using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace _36_Regex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string pattrern = @"\d";
            //var regex = new Regex(pattrern);
            //while (true)
            //{
            //    //string line = Console.ReadKey().KeyChar.ToString();
            //    string line = Console.ReadLine()!;
            //    if (line == " ")
            //    {
            //        break;
            //    }
            //    Console.WriteLine($" is number --> {regex.IsMatch(line)}");
            //}

            //var arr = new [] { "test", "123", "test123", "123test", "test123test" };
            //string pattern = @"\D{6,}"; // 6 і більше не цифри
            //var regex = new Regex(pattern);
            //foreach (var item in arr)
            //{
            //    Console.WriteLine($"{item} --> {regex.IsMatch(item)}");
            //}
            //Console.WriteLine();

            ////pattern = @"^[A-Z][a-z]"; // почанається з великої і наступна маленька
            ////pattern = @"^[A-Z][a-z]$"; // почанається з великої і наступна маленька і кінець
            //pattern = @"^[A-Z][a-z]*$"; // почанається з великої і наступні декілька маленьких
            //regex = new Regex(pattern);
            //while (true)
            //{
            //    Console.WriteLine("Enter Line: ");
            //    string line = Console.ReadLine();
            //    if (line == "exit") break;
            //    Console.WriteLine($"{line} --> {regex.IsMatch(line)}");
            //    Console.WriteLine($"{new string ('-', 50)}");
            //}

            //string value = "4 - 5 and 5 y 789";
            //Match match = Regex.Match(value, @"\d+");
            ////if ( match.Success)
            ////{
            ////    Console.WriteLine(match.Value);
            ////}
            ////match = match.NextMatch();
            ////if (match.Success)
            ////{
            ////    Console.WriteLine(match.Value);
            ////}
            //while (match.Success)
            //{
            //    Console.WriteLine($"value { match.Value} index {match.Index} lenght {match.Length}");
            //    match = match.NextMatch();
            //}

            //Match match = Regex.Match("123 Axxx-1-xxxy \n Axxx-2xxxy 541", @"A.*y");
            //while (match.Success)
            //{
            //    Console.WriteLine($"value {match.Value} inbdex {match.Index} leght {match.Length}");
            //    match = match.NextMatch();
            //}

            //string value = "saidsaid said shed shed see spear spear super";
            //var m = Regex.Matches(value, @"s\w+d");
            //foreach (Match item in m)
            //{
            //    Console.WriteLine($"value {item.Value} inbdex {item.Index} leght {item.Length}");
            //}

            //////////// REPLACE //////////
            //var input = "Dont replace Dot Net replaced Net net dots";
            //var output = Regex.Replace(input, @"N.t", "NET", RegexOptions.IgnoreCase); // ігнорувати регістр
            //Console.WriteLine(input);
            //Console.WriteLine(output);


            //+38(098)-12-12-123
            var text = "bla bla 124435974 argsss fsogj 439560235 ldzkjn 485930548 bye!";
            //var output = Regex.Replace(text, @"(\d{2})(\d{2})(\d{2})(\d{3})", "+38(0$1)-$2-$3-$4");
            var output = Regex.Replace(text, @"\d{9}", m => string.Format("{0:+38(0##)-##-##-###}", Convert.ToInt64( m.Value)));
            Console.WriteLine(text);
            Console.WriteLine(output);




        }
    }
}
