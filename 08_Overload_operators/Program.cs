namespace _08_Overload_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction one = new Fraction(1,2);
            Fraction two = new Fraction(2,3);
            Console.WriteLine($"One :: {one}\tTwo :: {two}");
            Console.WriteLine($"Num :: {one[0]}\tDemo :: {one[1]}");
            Console.WriteLine($"{one} + {two} = {one + two}");
            Console.WriteLine($"{one} == {two} =  {one == two}");
            Console.WriteLine($"{one} != {two} =  {one != two}");
            Console.WriteLine(one ? "True" : "False");
            Console.WriteLine(one++);
            Console.WriteLine(one);
            Console.WriteLine(++one);
            //Console.WriteLine($"{two }  ==> {(int)two}");
            Console.WriteLine($"{one}  ==> {(int)one}");

            double value;
            value = two;
            Console.WriteLine($"Resalt explicit => {value}");


        }
    }
}
