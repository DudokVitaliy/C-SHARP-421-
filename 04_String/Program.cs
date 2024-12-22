using System.Text;

namespace _04_String
{
    internal class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
        static int Sum(params int[] arr)
        {
            return arr.Sum();
        }
        static void Main(string[] args)
        {
            Sum (1, 2);
            Sum (1, 2, 3);
            Sum (1, 2, 3, 4, 5, 6);

            string text = "hello world C#";
            char[] chars = text.ToCharArray();
            chars[0] = char.ToUpper(text[0]);
            Console.WriteLine(text);
            Console.WriteLine(chars);

            text = new string(chars);
            Console.WriteLine(text);

            Console.WriteLine("Contains :: " + text.Contains("C#"));
            Console.WriteLine("Start With :: " + text.StartsWith("C#"));
            Console.WriteLine("End With :: " + text.EndsWith("C#"));

            var index = text.IndexOf("C#");
            Console.WriteLine("Index of :: " + index);
            index = text.IndexOfAny("abcd".ToCharArray());
            Console.WriteLine("Index of any :: " + index);
            string one = "Apple", two = "Apricot";
            Console.WriteLine($"Compare to :: {one.CompareTo(two)}");
            two = "apple";
            Console.WriteLine($"Compare to :: {one.CompareTo(two)}");
            Console.WriteLine($"Compare to :: {String.CompareOrdinal(one,two)}");
            Console.WriteLine($"Compare to :: {String.Compare(one,two, true)}");

            string numb = "1,2,3,4,5,6,7,8,9";
            string[] numbers = numb.Split( ',' );

            string[] colors = { "red", "yellow", "gold", "green", "purple" };
            Console.WriteLine(String.Join( ", ", colors));

            //StringBuilder text = new StringBuilder("hello world");
            //text[0] = char.ToUpper(text[0]);
            //Console.WriteLine(text);
            //Console.WriteLine(text.Capacity);
            //text.Append("!!!");
            //text.AppendLine(" Shoto tam");
            //Console.WriteLine(text);
            //text.Insert(0, "C# ");
            //Console.WriteLine(text);
            ////text.Remove(8, 10);
            ////Console.WriteLine(text);
            //text.Replace("C#", "JS");
            //Console.WriteLine(text);
            //Console.WriteLine(text.Capacity);
        }
    }
}
