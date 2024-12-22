
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    /*
    static void BadSwap(int x, int y)
    {
        var temp = x; x = y; y = temp;
    }
    static void Swap(ref int x, ref int y)
    {
        var temp = x; x = y; y = temp;
    }
    static void SumTwo(int x, int y, out int res)
    {
        res = x + y;
    }
    */
    static void Print<T>(T[] arr, string prompt = "")
    {
        Console.Write(prompt);
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write($"{arr[i], -10}");
        //}
        foreach (T i in arr)
        {  
            Console.Write($"{i,-10}"); 
        }
        Console.WriteLine();
    }
    static void FillRandom( int[] arr, int min = 0, int max = 50 )
    {
        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max);
        }
    }
    static void PushBack( ref int[] arr, int value)
    {
        //int[] tmp = new int[arr.Length + 1];

        ////for (int i = 0; i < arr.Length; i++)
        ////{
        ////    tmp[i] = arr[i];
        ////}
        //arr.CopyTo(tmp, 0);
        //tmp[tmp.Length - 1] = value;
        //arr = tmp;
        Array.Resize(ref arr, arr.Length+1);
        arr[arr.Length-1] = value;
    }
    private static void Main(string[] args)
    {
        /*
        // типи данних
        // - value type(int, double, char, bool, enum, struct)   - викор копію -> Stack
        // - reference type (class, interface, string, BuilderString, array, delegate) -   викор оригінал -> Hip
       
        // ref, out - передання за посиланням
        // ref - фактичний параметер який має бути проініціалізований
        // out - змінна може бути не проініціалізована (зазвичай викор для збережання результату)
        
        int a = 5, b = 10;
        Console.WriteLine($"a = {a, -10} \tb = {b}");
        BadSwap(a, b);
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a, -10} \tb = {b}");
        int res;
        SumTwo(a,b, out res);
        Console.WriteLine($"Resalt = {res}");
        */

        //int[] arr = new int[5];
        //int [] arr3 = { 1, 2, 3,4, 5, 6,7, 8, 9,10 };
        //int[] arr4; // = null
        //Print(arr2, "Print Array #1:: ");
        //Console.Write("Enter number of element: ");
        //int size = int.Parse( Console.ReadLine() );
        int size = 10;
        int[] rand_arr = new int [size];
        FillRandom(rand_arr, -10, 10);
        Print(rand_arr, "Print rand array:: ");
        //PushBack(ref rand_arr, 222);
        //Print(rand_arr, "Print after push array:: ");
        // бібліотека Linq - розширені методи для роботи з масивом
        int[] arr = new int [10]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int value = 5;
        arr.Contains(value);
        if (arr.Contains(value))
        {
            Console.WriteLine($"value {value} was found");
        }
        else
        {
            Console.WriteLine($"value {value} NOT found");
        }
        Console.WriteLine($"number of elements is positive :: {rand_arr.Count(IsPositive)}");
        int index = Array.IndexOf(rand_arr, value);
        if (index != -1)
        {
            Console.WriteLine($"value {value} = index {index}");
            int last_index = Array.LastIndexOf(rand_arr, value);
            Console.WriteLine($"value {value} = last index {last_index}");
        }
        else
        { Console.WriteLine($"value {value} NOT found"); }
        int firstPositive = Array.FindIndex(rand_arr, IsPositive);
        if ( firstPositive != -1)
        {
            Console.WriteLine($"firt pos index = {firstPositive}");  
            int lastPositive = Array.FindLastIndex(rand_arr,IsPositive);
            Console.WriteLine($"last pos index = {lastPositive}");  
        }
        index = Array.FindIndex(rand_arr, (int e) => { return e % 3 == 0; }); // lambda funct
        Console.WriteLine($"pos first number % 3 = {index}");
        int [] events = Array.FindAll(rand_arr, e => e % 2 == 0);
        Print(events, "events:: ");
        Console.WriteLine(Array.TrueForAll(rand_arr, IsPositive)); // викон для всіх
        Console.WriteLine(Array.Exists(rand_arr, IsPositive)); // хоча б для одного
        Print(rand_arr, "Print rand array:: ");
        Array.Sort(rand_arr);
        Print(rand_arr, "Print sorted rand array:: ");
        Array.Reverse(rand_arr);
        Print(rand_arr, "Print reversed rand array:: ");
        Console.WriteLine(rand_arr.Sum());
        Console.WriteLine(rand_arr.Min());
        Console.WriteLine(rand_arr.Max());
        string[] colors = { "red", "yellow", "gold", "green", "purple" };
        Print(colors, "Print colors array:: ");
        Array.Sort(colors);
        Print(colors, "Print colors array:: ");
        Array.Sort(colors, (s1, s2) => s1.Length.CompareTo(s2.Length));
        Print(colors, "Print colors array:: ");
    }
    static bool IsPositive(int a)
    {
        return a > 0;
    }
}