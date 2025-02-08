namespace _29_SreamWriterReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "../../info.txt";
            //using (StreamWriter sw = new StreamWriter(fname))
            //{
            //    string line = "Hello from Kiyv";
            //    int value = 123123;
            //    DateTime today = DateTime.Now;
            //    int[] arr = { 10, 20, 30 };

            //    sw.WriteLine(line);
            //    sw.WriteLine($"value :: {value}");
            //    sw.WriteLine(today);
            //    sw.WriteLine(arr.Length);
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sw.WriteLine(arr[i]);
            //    }
            //}
            Console.WriteLine("Reading SreamWrite");
            Console.WriteLine("Reading All Lines");
            string[] lines = File.ReadAllLines(fname);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine(new string('*', 50));
            Console.WriteLine($"Reading All Text\n{File.ReadAllText(fname)}");
            Console.WriteLine(new string('*', 50));
            using(StreamReader sr = new StreamReader(fname))
            {
                Console.WriteLine("Read to end: ");
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine(new string('*', 50));
            using (StreamReader sr = new StreamReader(fname))
            {
                Console.WriteLine("Read to lines: ");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            Console.WriteLine("Read char by char: ");
            using (StreamReader sr = new StreamReader(fname))
            {
                int symb;
                while ((symb = sr.Read()) != -1)
                {
                    Console.WriteLine((char)symb);
                }

            }
        }
    }
}
