namespace _09_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix (2, 2);
            Console.WriteLine(matrix[0,0]);
            Console.WriteLine(matrix);
            Console.WriteLine("\n" + new string('=', 40) + '\n');
            matrix[0, 0] = 10;
            matrix[0,1] = 20;
            matrix[1, 0] = 30;
            matrix[1, 1] = 40;
            matrix[1, 3] = 40;
            Console.WriteLine(matrix);

        }
    }
}
