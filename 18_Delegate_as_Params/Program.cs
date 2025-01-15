namespace _18_Delegate_as_Params
{
    delegate bool Condition<T>(T numb); // узагальнений делегат для різних типів данних
    internal class Program
    {
        
        public static int CountInArray<T>(T[] array, Condition<T> func)
        {
            int count = 0;
            foreach (T i in array)
            {
                if (func(i))
                    count++;
            }
            return count;
        }
        //public static int CountInArrayNegative(int[] array)
        //{
        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] < 0)
        //            count++;
        //    }
        //    return count;
        //}
        //public static int CountInArrayEven(int[] array)
        //{
        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] % 2 == 0)
        //            count++;
        //    }
        //    return count;
        //}
        //public static int CountInArrayOdd(int[] array)
        //{
        //    int count = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] % 2 != 0)
        //            count++;
        //    }
        //    return count;
        //}

        public static T[] FilterArray<T>(T[] arr, Condition<T> func)
        {
            T[] array = new T[0];
            foreach (T item in arr)
            {
                if (func(item))
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = item;
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, -1, -5, 4, 6, -3, - 7, 9 };
            Console.WriteLine($"Number pos elem :: {CountInArray(arr, e => e > 0)}");
            Console.WriteLine($"Number neg elem :: {CountInArray(arr, e => e < 0)}");
            Console.WriteLine($"Number odd elem :: {CountInArray(arr, e => e % 2 != 0)}");
            Console.WriteLine($"Number even elem :: {CountInArray(arr, e => e % 2 == 0)}");

            double[] arr2 = { 1.5, 2, -1, -5.1, 4, 6, -3.3, - 7, 9 };
            Console.WriteLine($"Number pos elem :: {CountInArray(arr2, e => e > 0)}");

            string[] arr3 = { "red", "green", "yellow" };
            Console.WriteLine($"Number words with len > 5 :: {CountInArray(arr3, e => e.Length > 5)}");

            Console.WriteLine("------------------------------ + -------------------------------------");
            Console.WriteLine(String.Join(", ", FilterArray(arr, e => e > 0)));

        }
    }
}
