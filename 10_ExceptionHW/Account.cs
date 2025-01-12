using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExceptionHW
{
    internal class Account
    {
        private string email;
        private string password;
        static bool HasSymbol(char a)
        {
            return a == '@';
        }
        public string Email { get => email;
            set
            {
                char[] chars = value.ToCharArray();
                if (chars.Length > 50 || chars.Length < 4)
                {
                    throw new Exception("Email must contain 4 to 50 symbolі!!!");
                }
                if (Array.FindIndex(chars, HasSymbol) == -1)
                {
                    throw new Exception("Email must have '@' - symbol!!!");
                }
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] != '_' && chars[i] != '@' && chars[i] != '.' && !Char.IsLetter(chars[i]) && !Char.IsDigit(chars[i]))
                    {
                        throw new Exception(@"Email must contain only letters, decimal numbers and the symbol '_'!!!");
                    }
                }
                email = value;
                
            }
                
        }
        public string Password { get => password;
            set
            {
                char[] chars = value.ToCharArray();
                if (chars.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters long!!!");
                }
                int firstLetter = Array.FindIndex(chars, (char e) => { return Char.IsLetter(e); });
                int firstDigit = Array.FindIndex(chars, (char e) => { return Char.IsNumber(e); });
                if (firstLetter == -1 || firstDigit == -1)
                {
                    throw new Exception("The password must contain both letters and numbers!!!");
                }
                password = value;
            }
        }
        public override string ToString()
        {
            return $"\temail\t::{Email}\n\tpassword::{Password}";
        }
    }
}
