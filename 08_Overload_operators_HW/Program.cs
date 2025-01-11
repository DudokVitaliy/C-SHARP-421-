namespace _08_Overload_operators_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector vector = new Vector(3, 4);
            Console.WriteLine(vector);
            Console.WriteLine($"Lenght = {vector.Length()}");
            Vector vector2 = new Vector(1, 1);
            Console.WriteLine($"{vector} + {vector2} = {vector + vector2}");
            Console.WriteLine($"{vector} - {vector2} = {vector - vector2}");
            Console.WriteLine($"{vector} * 5 = {vector * 5}");
            Console.WriteLine($"{vector} * {vector2} = {vector * vector2}");
            Console.WriteLine($"{vector} == {vector2} = {vector == vector2}");
            Console.WriteLine($"{vector} != {vector2} = {vector != vector2}");
            Console.WriteLine($"explicit {vector} to double => {(double)vector}");
            Vector vector3 = 3;
            Console.WriteLine($"implicit 3 to vector => {vector3}");
            Console.WriteLine($"++{vector} = {++vector}");
            Console.WriteLine($"--{vector} = {--vector}");
            Console.WriteLine($"-{vector} = {-vector}");
            Console.WriteLine($"{vector} true or false: " + (vector ? "True" : "False"));
            Vector vector4 = new Vector(0, 0);
            Console.WriteLine($"{vector4} true or false: " + (vector4 ? "True" : "False"));
            Console.WriteLine($"{vector}[0] = {vector[0]}");
            Console.WriteLine($"{vector}[1] = {vector[1]}");
            Console.WriteLine($"{vector}[3] = {vector[3]}");
            Console.WriteLine($"{vector} += 5 = {vector+= 5}");
            Console.WriteLine($"{vector} += {vector2} = {vector+= vector2}");
            Console.WriteLine($"{vector} -= 3 = {vector-= 3}");
            Console.WriteLine($"{vector} -= {vector2} = {vector-= vector2}");
            Console.WriteLine($"{vector} *= 3 = {vector*= 3}");
            Console.WriteLine($"{vector} *= {vector2} = {(double)(vector*= vector2)}");

        }
    }
}
