namespace _10_Exception
{
    internal class Program
    {
        static int DivideNumber(int a, int b)
        {
            int result = 0;
            try
            {
                result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Inner exception --> "+ ex.Message);
                throw;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a, b, result;
            /*
            while (true) 
            {
                try
                {
                    Console.WriteLine("Enter two number :: ");
                    a = int.Parse(Console.ReadLine()!);
                    b = int.Parse(Console.ReadLine()!);
                    result = DivideNumber(a, b);
                    Console.WriteLine($"{a} / {b} = {result}");
                    break;
                }
                catch (DivideByZeroException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\tMessage        :: {ex.Message}");
                    Console.WriteLine($"\tHelpLink       :: {ex.HelpLink}");
                    Console.WriteLine($"\tSource         :: {ex.Source}");
                    Console.WriteLine($"\tTargetSite     :: {ex.TargetSite}");
                    foreach (var key in ex.Data.Keys)
                    {
                        Console.WriteLine($"{key} -> {ex.Data[key]}");
                    }
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\tMessage        :: {ex.Message}");
                    Console.ResetColor();
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Finally");
                    Console.ResetColor();
                }
            }
            */
            Product product = new Product();
            try
            {
                product.Name = "bread";//"black bread";
                product.DateIn = DateTime.Parse("10/12/2025");
            }
            catch (BadDateProductException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\tMessage        :: {ex.Message}");
                Console.WriteLine($"\tError date     :: {ex.errorDate}");
                Console.WriteLine($"\tSource         :: {ex.Source}");
                Console.WriteLine($"\tTargetSite     :: {ex.TargetSite}");            
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\tMessage        :: {ex.Message}");
                Console.WriteLine($"\tHelpLink       :: {ex.HelpLink}");
                Console.WriteLine($"\tSource         :: {ex.Source}");
                Console.WriteLine($"\tTargetSite     :: {ex.TargetSite}");
                foreach (var key in ex.Data.Keys)
                {
                    Console.WriteLine($"{key} -> {ex.Data[key]}");
                }
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Name product :: {product.Name,-10} Date :: {product.DateIn}");
            Console.ResetColor();
        }
    }
}
