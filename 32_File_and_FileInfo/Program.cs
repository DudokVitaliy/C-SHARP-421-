namespace _32_File_and_FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "line1", "line2" };
            string fname = "my.txt";
            //File.SetAttributes(fname, FileAttributes.Archive);
            if (File.Exists(fname))
            {
                File.Delete(fname);
                Console.WriteLine($"File {fname} deleted!");
            }
            File.AppendAllLines(fname, lines);
            File.AppendAllText(fname, "line3\nline4");
            Console.WriteLine($"Content text: \n{File.ReadAllText(fname)}");
            Console.WriteLine($"Content lines: \n{String.Join('\n', File.ReadAllText(fname))}");

            string fname2 = "copy.txt";
            File.Copy(fname, fname2, true);
            Console.WriteLine($"Content copy lines: \n{String.Join('\n', File.ReadAllText(fname2))}");
            //FileStream fs = File.Create(fname2);
            StreamWriter sw = File.CreateText(fname);
            sw.WriteLine("Write something...");
            sw.Close();
            File.AppendAllText(fname, "New line");
            Console.WriteLine($"Content lines: \n{String.Join('\n', File.ReadAllText(fname))}");
            Console.WriteLine($"Creation time: {File.GetCreationTime(fname)}");
            Console.WriteLine($"Last write time: {File.GetLastWriteTime(fname)}");

            string fname3 = "third.txt";
            FileInfo file = new FileInfo(fname3);
            Console.WriteLine();
            Console.WriteLine($"Exists file {fname3} :: {file.Exists}");
            if (!file.Exists)
            {
                using (var tw = file.CreateText())
                {
                    tw.WriteLine("It is third file");
                }
            }
            Console.WriteLine($"Full name     : {file.FullName}");
            Console.WriteLine($"Name          : {file.Name}");
            Console.WriteLine($"Directory     : {file.Directory}");
            Console.WriteLine($"Directory Name: {Path.GetFileName(file.DirectoryName)}");
            Console.WriteLine($"Content of file {fname3}:: \n {File.ReadAllText(fname3)}");
            // перемістити файл
            //file.MoveTo("./third.txt", true); // ./ поточна папка

            //Console.WriteLine($"Move to path {Path.Combine(".","third.txt")}");
            //Console.WriteLine($"Move to path {Path.Combine(".", fifileName)}");
            //fi.MoveTo(Path.Combine(".",fi.Name),true);
            Console.WriteLine($"Length of {file.Name} :: {file.Length}");
            Console.WriteLine($"Extension of {file.Name} :: {file.Extension}");
            Console.WriteLine($"File attributes  of {fname} :: {File.GetAttributes(fname)}");
            File.SetAttributes(fname, FileAttributes.ReadOnly);
            Console.WriteLine($"File attributes  of {fname} :: {File.GetAttributes(fname)}");


        
        }
    }
}
