using System.Text;

namespace _28_BinaryWriterReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "../../data.dat";
            //using (BinaryWriter br = new BinaryWriter(new FileStream(fname, FileMode.Create)))
            //{
            //    string test = "Test - line Тестоаий рядок";
            //    double valueD = 23.23;
            //    int valueI = 877;
            //    int[] arr = { 1, 2, 3, 4 };
            //    br.Write(test);
            //    br.Write(valueD);
            //    br.Write(valueI);
            //    br.Write(arr.Length);
            //    foreach (var item in arr)
            //    {
            //        br.Write(item);
            //    }
            //}
            Console.OutputEncoding = Encoding.UTF8;
            using (BinaryReader br = new BinaryReader(new FileStream (fname, FileMode.Open)))
            {
                string readstr = br.ReadString ();
                Console.WriteLine (readstr);
                Console.WriteLine (br.ReadDouble());
                Console.WriteLine (br.ReadInt32());
                Console.WriteLine ("Array: ");
                int[] arr = new int[br.ReadInt32()];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr [i] = br.ReadInt32();
                }
                Console.WriteLine (String.Join (",", arr));
            }
        }
    }
}
