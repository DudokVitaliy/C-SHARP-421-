namespace IClonable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Sasha", 10,11,9,12,10);
            Console.WriteLine($"Origin: {student}");

            Student clone = (student.Clone() as Student)!;
            Console.WriteLine($"Clone: {clone}\n");
            clone.Name = "Olga";
            clone[0] = 2;
            clone[1] = 4;
            Console.WriteLine($"Origin: {student}");
            Console.WriteLine($"Clone: {clone}\n");
        }
    }
}
