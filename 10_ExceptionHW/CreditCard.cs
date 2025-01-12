using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExceptionHW
{
    class CreditCard
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    throw new Exception("Error! Name can`t be empty!");
            }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    surname = value;
                else
                    throw new Exception("Error! Surname can`t be empty!");
            }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length < 16 || value.Length > 16)
                    throw new Exception("Error! Card number must be 16!");
                else if (!(long.Parse(value) is long))
                    throw new Exception("Error! Card number can`t has letters!");
                else
                    number = value;
            }
        }
        private int cvv;

        public int Cvv
        {
            get { return cvv; }
            set
            {
                if (value > 999 || value < 100)
                    throw new Exception("Error! CVV code can has only 3 numbers!");
                else
                    cvv = value;
            }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value >= DateTime.Now)
                    date = value;
                else
                    //date = value;
                    throw new Exception("Error! The Validity period of the card has expired!");
            }
        }
        public CreditCard(string name, string surname, string number, int cvv, DateTime date)
        {
            Name = name;
            Surname = surname;
            Number = number;
            Cvv = cvv;
            Date = date;
        }
        public CreditCard() : this("empty", "empty", "0000000000000000", 111, new DateTime(9999, 12, 12)) { }
        public override string ToString()
        {
            return $"\tCard info:\n\tName: {Name}\t{Surname}\n\tCard number: {Number}\n\tCVV: {Cvv}\n\tValid until: {Date.ToShortDateString()}";
        }
        public void FillInfo()
        {
            try
            {
                Console.WriteLine("\tFill card info:");
                Console.Write($"Name:"); Name = Console.ReadLine();
                Console.Write($"Surname:"); Surname = Console.ReadLine();
                Console.Write($"Card number:"); Number = Console.ReadLine();
                Console.Write($"CVV:"); Cvv = int.Parse(Console.ReadLine());
                Console.Write($"Valid until:"); Date = DateTime.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Filled successfully!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine("Now try again and be more careful!");
                FillInfo();
            }
        }
    }
}
