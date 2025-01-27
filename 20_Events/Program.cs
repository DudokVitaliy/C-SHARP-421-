namespace _20_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company softServe = new Company() { Name = "SoftServe"};
            Company honeyComb = new Company() { Name = "HoneyComb"};

            Interviwer maria = new Interviwer() { Name = "Maria" };
            Interviwer ivan = new Interviwer() { Name = "Ivan" };

            softServe.NewPosition += maria.DoSomething;
            softServe.NewPosition += ivan.DoSomething;

            honeyComb.NewPosition += maria.DoSomething;
            honeyComb.NewPosition += ivan.DoSomething;

            softServe.AddPosition("Intern C++");
            Console.WriteLine();
            Console.ReadKey();
            honeyComb.AddPosition("Junior .NET");

            honeyComb.NewPosition -= maria.DoSomething;
            
            Console.WriteLine();
            Console.ReadKey();
            honeyComb.AddPosition("Middle fronted");
        }
    }
}
