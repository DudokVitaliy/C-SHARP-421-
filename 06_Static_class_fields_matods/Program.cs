using System.Reflection.Metadata.Ecma335;

namespace _06_Static_class_fields_matods
{
    internal class Program
    {
        static class AreaShapes
        {
            const double PI = 3.14;
            public static double TrianArea(double height, double side)
            { 
                return 0.5 * height * side ;
            }
            public static double CircleArea(double radius) 
                { return PI * Math.Pow(radius, 2); }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started...");
            Console.WriteLine($"Last ID :: {Employee.LastId}");
            Employee employee = new Employee() { Name = "Denis", Birth = DateTime.Parse("30/10/2000"), Position = Position.Manager };
            Console.WriteLine(employee);
            Employee employee2 = new Employee()
            {
                Name = "Ivan",
                Birth = new DateTime (2005, 12, 29),
                Position = Position.Manager
            };
            Console.WriteLine(employee2);
            Console.WriteLine($"Same position :: {Employee.SamePosition(employee, employee2)}");
            Console.WriteLine($"Last ID :: {Employee.LastId}");

            Console.WriteLine(AreaShapes.TrianArea(10, 4));
        }
    }
}
