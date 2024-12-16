using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        
        WriteLine("\t\tN1");
        WriteLine("\tAll positions: intern, junior, specialist, manager, director");
        Write("\tEnter position: ");
        string position = ReadLine();
        Write("\tEnter number of hours: \t");
        int hours = int.Parse(ReadLine());
        int result = 0;
        switch (position)
        {
            case "intern":
                result = hours * 100;
                break;
            case "junior":
                result = hours * 150;
                break;
            case "specialist":
                result = hours * 200;
                break;
            case "manager":
                result = hours * 300;
                break;
            case "director":
                result = hours * 500;
                break;
            default:
                break;
        }
        WriteLine($"\tResult = {result} UAH");
        WriteLine("\t\tN2");
        Write("\tEnter start: \t"); int start = int.Parse(ReadLine());
        Write("\tEnter end: \t"); int end = int.Parse(ReadLine());
        for (int i = start; i <= end; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Write(i);
            }
            WriteLine();
        }

        WriteLine("\t\tN3");
        int count_space = 0;
        int count_lett = 0;
        int count_numb = 0;
        int count_symb = 0;

        while (true)
        {
            Write("\tEnter one symbol: ");
            string input = ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                continue;
            }
            char one_char = input[0];
            if (char.IsDigit(one_char))
                count_numb++;
            else if (char.IsLetter(one_char))
                count_lett++;
            else if (char.IsWhiteSpace(one_char))
                count_space++;
            else if (one_char == '.')
            {
                count_symb++;
                break;
            }
            else
                count_symb++;
            one_char = '\0';
        }
        WriteLine($"\tResult: \n\tspace = {count_space}\n\tletter = {count_lett}\n\tdigit = {count_numb}\n\tsymbol = {count_symb}");
        
        WriteLine("\t\tN4");
        // щоб продовжити кожного разу потрібно натиснути Enter
        ConsoleKey key;
        char one_letter;
        WriteLine("\t\tEsc - Exit\t\tEnter - continue");
        while ((key = Console.ReadKey().Key) != ConsoleKey.Escape)
        { 
            Write("\tEnter one letter: ");
            string input = ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                continue;
            }
            one_letter = input[0];
            if (char.IsLower(one_letter))
            {
                WriteLine("\tResult: " + char.ToUpper(one_letter));
            }
            else if (char.IsUpper(one_letter))
            {
                WriteLine("\tResult: " + char.ToLower(one_letter));
            }
            WriteLine("\t\tEsc - Exit\t\tEnter - continue");

        }

    }
}