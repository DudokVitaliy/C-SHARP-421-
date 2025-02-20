using System.Text;

namespace _33_Directory_and_DirecftoryInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current path :\n {Directory.GetCurrentDirectory()}");
            Directory.CreateDirectory("A");
            Directory.SetCurrentDirectory("A");
            Console.WriteLine($"Current path :\n {Directory.GetCurrentDirectory()}");

            Directory.CreateDirectory("A1");
            Directory.CreateDirectory("A2");
            File.WriteAllText("a.txt", "File a.txt content");
            File.WriteAllText("b.txt", "File b.txt content \n Some info\n");

            File.WriteAllText("A1/a1.txt", "File a1.txt content");
            File.WriteAllText("A2/a2.txt", "File a2.txt content");

            //var files = Directory.GetFiles(".");
            var files = Directory.GetFiles(".", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var dir = Directory.GetDirectories(".");
            Console.WriteLine("List directories from folder A");
            foreach ( var d in dir)
            {
                Console.WriteLine(d);
                Console.WriteLine(Path.GetFileName(d));
            }
            Console.OutputEncoding = Encoding.Unicode;
            string path = @"C:\Users\TechnoRoom\Downloads";
            var entries = Directory.GetFileSystemEntries(path);
            Console.WriteLine($"\n\n----- {path}");
            foreach ( var e in entries)
            {
                //Console.WriteLine(e);
                FileInfo fi = new FileInfo(e);
                string info = "<DIR>";
                if (!fi.Attributes.HasFlag(FileAttributes.Directory))
                {
                    info = fi.Length.ToString();
                    Console.WriteLine($"{fi.CreationTime, -22} {fi.Name, -30} {info}");
                }
            }

            //get files from folder A
            /*string[] fnames = Directory.GetFiles(".","a*.*"); // список файлів що починаються на букву а
            Console.WriteLine(String.Join<string>("\n",fnames));*/

            //string[] fnames = Directory.GetFiles(".", "*.txt", SearchOption.AllDirectories); // зайде у під-папки теж
            //Console.WriteLine(String.Join<string>("\n", fnames));
            //foreach (var item in fnames)
            //{
            //    Console.WriteLine($"{Path.GetFileName(item)} in {Path.GetDirectoryName(item)}");
            //}
            //string[] dirs = Directory.GetDirectories(".");
            //Console.WriteLine($"\n List folder from folder A");
            //foreach (var item in dirs)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine(Path.GetFileName(item));
            //}
            //string path = @"C:\\Users\\konopelko\\Downloads";
            //string[] entries = Directory.GetFileSystemEntries(path);
            //Console.WriteLine($"\n\n ------ {path}");
            //Console.OutputEncoding = Encoding.Unicode;
            //foreach (var item in entries)
            //{
            //    FileInfo fi = new FileInfo(item);
            //    string info = "<DIR>";
            //    if (!fi.Attributes.HasFlag(FileAttributes.Directory))
            //        info = fi.Length.ToString();
            //    Console.WriteLine($"{fi.CreationTime,-22}{fi.Name,-30} {info,-15}");
            //}

            path = "B";
            DirectoryInfo di = new DirectoryInfo(path);
            if (!di.Exists)
                di.Create();
            Console.WriteLine($"Attrib of B :: {di.Attributes}");
            File.WriteAllText("B/b1.txt", "Hello from b1.txt");
            File.WriteAllText("B/b2.txt", "Hello from b2.txt");
            FileInfo[] listFl = di.GetFiles();
            foreach (var item in listFl)
            {
                Console.WriteLine($"{item.Name}  :: {item.Length}");
            }


        }
    }
}
