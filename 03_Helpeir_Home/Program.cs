namespace _03_Helpeir_Home
{
    internal class Program
    {
        static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++) // по рядках
            {
                for(int j = 0; j < arr.GetLength(1); j++) // по колонках
                {
                    Console.Write($"{arr[i, j], -10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Print(int[][] arr)
        {
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write($"{arr[i][j],-10}");
            //    }
            //    Console.WriteLine();
            //}
            foreach (int[] row in arr)
            {
                foreach(int item in row)
                {
                    Console.Write($"{item, -10}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void MathRows(int[][] arr)
        {
            foreach (var row in arr)
            {
                Console.WriteLine($"sum :: {row.Sum()}");
                Console.WriteLine($"min :: {row.Min()}");
                Console.WriteLine($"max :: {row.Max()}");
                Console.WriteLine($"avg :: {row.Average()}");
                Console.WriteLine();
            }
        }
        static void SwapRows(int[][] arr, int row1, int row2)
        {
            if(row1 >= 0 && row2 >= 0 && row1 < arr.Length && row2 < arr.Length)
            {
                int[] tmp = arr[row1];
                arr[row1] = arr[row2];
                arr[row2] = tmp;
            }
        }
        static void Main(string[] args)
        {
            // ДВОВИМІРНИЙ МАСИВ
            int[,] arr = new int[3, 4] 
            {{ 1,2,3,4},
            { 5,6,7,8},
            { 9,10,11,12} };
            Print(arr);
            arr[0, 0] = 777;
            Print(arr);
            Console.WriteLine($"Array Lenght :: {arr.Length}");
            Console.WriteLine($"Array Lenght :: {arr}");
            // строкатий двовимірний масив
            int[][] arr1 = new int[4][];
            arr1[0] = new [] { 1, 2, 3, 4, 5, 6 };
            arr1[1] = new [] { 31,32 };
            arr1[2] = new [] { 11,12,13};
            arr1[3] = new [] { 22,24,25,27 };
            Print(arr1);
            //MathRows(arr1);
            for (int i = 0; i < arr1.Length / 2; i++)
            {
                SwapRows(arr1, i, arr1.Length - 1- i);
            }
            Print(arr1);

        }
    }
}
