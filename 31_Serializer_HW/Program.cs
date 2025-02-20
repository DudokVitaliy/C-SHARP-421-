namespace _31_Serializer_HW
{
    internal class Program
    {
        static void FilterArray
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\tEnter Array: ");
                string line = Console.ReadLine();
                string[] elements = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] arr = new int[elements.Length];
                for (int i = 0; i < elements.Length; i++)
                {
                    arr[i] = int.Parse(elements[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error! Incorect Data!");
            }
            
            Console.WriteLine("\tFilter Type: ");
            Console.WriteLine("1 - Delete Single Numbers");
            Console.WriteLine("2 - Delete Fibonacci Numbers");
            Console.WriteLine("-> "); int choise = int.Parse(Console.ReadLine());
            if ( choise == 1 ) {


            
        }
    }
}
