using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Class_HW
{
    internal class Magazine
    {
        private string name;
        private int year;
        private string description;
        private string phone;
        private string email;
        public string Name
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                else
                    name = "empty";
            }
            get => name;
        }
        public int Year
        {
            set
            {
                if (value > 1665 && value < DateTime.Now.Year ) // google пише що це дата друку першого журналу
                    year = value;
                else
                    year = 1665;
            }
            get => year;
        }
        public string Description
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
                else
                    description = "empty";
            }
            get => description;
        }
        public string Phone
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 9)
                    phone = value;
                else
                    phone = "000000000";
            }
            get => phone;
        }
        public string Email
        {
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    email = value;
                else
                    email = "empty";
            }
            get => email;
        }
        public override string ToString() =>
            $"\tYour Magazine: \nName :: {Name}\nYear :: {Year}\nDescription :: {Description}\nPhone :: 380{Phone}\nEmail :: {Email}";
        public void FillInfo()
        {
            Console.WriteLine("\tEnter all magazine info: ");
            Console.Write("Name: \t\t"); Name = Console.ReadLine();
            Console.Write("Year: \t\t");
            string year = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(year))
                Year = int.Parse(year);

            Console.Write("Description:\t"); Description = Console.ReadLine();
            Console.Write("Phone: \t\t"); Phone = Console.ReadLine();
            Console.Write("Email: \t\t"); Email = Console.ReadLine();
        }


    }
}
