namespace _13_Intarface_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10);
            array.Show();
            Console.WriteLine($"\tGreater      :: {array.Greater(0),5}");
            Console.WriteLine($"\tLess         :: {array.Less(0),5}");
            Console.Write($"\tEven         :: "); array.ShowEven();
            Console.Write($"\tOdd          :: "); array.ShowOdd();
            Console.WriteLine($"\tCountDistinct:: {array.CountDistinct(),5}");
            Console.WriteLine($"\tEqualToValue :: {array.EqualToValue(0),5}");
        }
    }
}
