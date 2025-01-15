namespace _16_Struct_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(1,5);
            Fraction fr2 = new Fraction(2,3);
            Console.WriteLine($"{fr1} + {fr2} = {fr1 + fr2}");
            Console.WriteLine($"{fr1} - {fr2} = {fr1 - fr2}");
            Console.WriteLine($"{fr1} * {fr2} = {fr1 * fr2}");
            Console.WriteLine($"{fr1} / {fr2} = {fr1 / fr2}");

            Vector v1 = new Vector(1,2,3);
            Vector v2 = new Vector(5,6,7);
            double x = 5;
            Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
            Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            Console.WriteLine($"{v1} * {x} = {v1 * x}");

        }
    }
}
