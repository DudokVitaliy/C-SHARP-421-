using System.Security.Cryptography;
using System.Text;

namespace _27_FileStream
{
    internal class Program
    {
        static void WriteAndReadBytes()
        {
            string fname = "bytes.dat";
            using (FileStream fs = new FileStream(fname, FileMode.OpenOrCreate))
            {
                byte byte_value = 65;//A;
                byte[] buffer = { 10, 11, 12, 13, 14, 15 };
                fs.WriteByte(byte_value);
                fs.Write(buffer, 0, buffer.Length);

                //fs.Position = 0;
                fs.Seek(0, SeekOrigin.Begin);
                //fs.Seek(-2, SeekOrigin.End);
                Console.WriteLine($"File size in bytes :: {fs.Length}");
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);
                Console.WriteLine($"Raed array :: {String.Join<byte>("\t", bytes)}");
            }
            //fs.Close();
        }
        static void WriteString(string value, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte [] bytes = Encoding.Unicode.GetBytes(value);
                fs.Write (bytes, 0, bytes.Length);
            }
        }
        static string ReadString(string path)
        {
            string value = String.Empty;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte [fs.Length];
                fs.Read (bytes, 0, bytes.Length);
                value = Encoding.Unicode.GetString(bytes);
            }
            return value;
        }
        static void WriteInt(int value, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = BitConverter.GetBytes(value);
                //Console.WriteLine(String.Join<byte>("\t", bytes));
                fs.Write(bytes, 0, bytes.Length);
            }
        }
        static int ReadInt(string path)
        {
            int value = 0;
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[sizeof(int)];
                fs.Read(bytes, 0, bytes.Length);
                value = BitConverter.ToInt32(bytes, 0);
            }
            return value;
        }
        static void WriteIntToFs(int value, FileStream fs)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            fs.Write(bytes, 0, bytes.Length);
        }
        static void Main(string[] args)
        {
            //string fname = "../../string.dat";
            //WriteString("Hello", fname);
            //Console.WriteLine(ReadString(fname));
            string fnumber = "../../number.dat";
            //WriteInt(-1223298, fnumber);
            //Console.WriteLine(ReadInt(fnumber));
            using (FileStream fs = new FileStream(fnumber, FileMode.Create))
            {
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                foreach (int i in arr)
                {
                    //WriteIntToFs(i, fs);
                }
                
            }


        }
        
    }
}
