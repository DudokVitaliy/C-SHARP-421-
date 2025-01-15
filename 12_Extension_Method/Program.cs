namespace _12_Extension_Method
{
    static class ExtansionInt
    {
        public static uint CountDigit(this int number)
        {
            return (uint)Math.Abs(number).ToString().Length;
        }
    }
    static class ExtansionArray
    {
        public static int SumPositiveElem(this int[] array)
        {
            return Array.FindAll(array, x => x > 0).Sum();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int value = -2134432;
            Console.WriteLine(value.CountDigit());
            int[] arr = { 1, 2, 3, -4, 11, -4 };
            Console.WriteLine(arr.SumPositiveElem());   
        }
    }
}
