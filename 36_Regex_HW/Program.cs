using System.Text.RegularExpressions;

namespace _36_Regex_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tN1");
            string input = "123 4567 12345 6789 100000 1234";
            Regex regex = new Regex(@"\b\d{4}\b");
            MatchCollection matches = regex.Matches(input);
            List<string> results = new List<string>();

            foreach (Match match in matches)
            {
                results.Add(match.Value);
            }

            foreach (var result in results)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("\tN2");
            string input2 = "asd123zxc456 bnm567hjk890 abc123def456";
            Regex regex2 = new Regex(@"[a-zA-Z]{3}\d{3}[a-zA-Z]{3}\d{3}");
            MatchCollection matches2 = regex2.Matches(input2);

            foreach (Match match in matches2)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("\tN3");
            string input3 = "WWW PDF RTF RTC BMP ABC";
            Regex regex3 = new Regex(@"\b[A-Z]{3}\b");
            MatchCollection matches3 = regex3.Matches(input3);

            foreach (Match match in matches3)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("\tN4");
            string input4 = "1999 2000 2100 1985 2050 1899";
            Regex regex4 = new Regex(@"\b(19|20)\d{2}\b");
            MatchCollection matches4 = regex4.Matches(input4);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("\tN5 (1)");
            string input5 = "+38-067-1234567 +38-068-2345678 +38-070-9999923";
            Regex regex5 = new Regex(@"\+38-0\d{2}-\d{5}23");
            MatchCollection matches5 = regex5.Matches(input5);

            foreach (Match match in matches5)
            {
                Console.WriteLine(match.Value);
            }

            Console.WriteLine("\tN5 (2)");
            string input6 = "+38-067-1200001 +38-067-9876003 +38-068-0001234";
            Regex regex6 = new Regex(@"\+38-0\d{2}-\d*(00)\d*");
            MatchCollection matches6 = regex6.Matches(input6);

            foreach (Match match in matches6)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
