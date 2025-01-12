namespace _10_ExceptionHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t1) Account");
            Console.WriteLine("\tFill info:");
            Account account = new Account();
            while (true)
            {
                try
                {
                    Console.Write("Email\t:: ");
                    account.Email = Console.ReadLine()!;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tEmail is correct!");
                    Console.ResetColor();
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tIncorect email!");
                    Console.WriteLine($"\tERROR::{ex.Message}");
                    Console.ResetColor();
                    Console.WriteLine("\tTry again!");
                }
            }
            while(true)
            {
                try
                {
                    Console.Write("Password:: ");
                    account.Password = Console.ReadLine()!;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tPassword is correct!");
                    Console.ResetColor();
                    break;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tIncorect password!");
                    Console.WriteLine($"\tERROR::{ex.Message}");
                    Console.ResetColor();
                    Console.WriteLine("\tTry again!");
                }
            }
            Console.WriteLine("Result:");
            Console.WriteLine(account);
            Console.WriteLine("\t\t2) Credit card");
            CreditCard card = new CreditCard();
            Console.WriteLine(card);
            card.FillInfo();
            Console.WriteLine(card);
        }
    }
}
