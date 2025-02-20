using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _00_Finall_Work
{

    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        public static User Register(string login, string password, DateTime birthDate)
        {
            if (!IsLoginValid(login))
            {
                Console.WriteLine("Incorrect login! The login must be between 3 and 15 characters long and contain only letters and numbers!");
                return null;
            }

            if (!IsPasswordValid(password))
            {
                Console.WriteLine("The password does not meet the requirements! The password must have a capital letter, a number, and at least 8 characters!");
                return null;
            }

            User existingUser = Load(login);
            if (existingUser != null)
            {
                Console.WriteLine("A user with this login already exists!");
                return null;
            }

            User newUser = new User { Login = login, Password = password, BirthDate = birthDate };
            newUser.Save();
            return newUser;
        }

        private static bool IsLoginValid(string login)
        {
            return login.Length >= 3 && login.Length <= 15 && Regex.IsMatch(login, @"^[a-zA-Z0-9]+$");
        }

        private static bool IsPasswordValid(string password)
        {
            return password.Length >= 8 && Regex.IsMatch(password, @"[A-Z]") && Regex.IsMatch(password, @"[0-9]");
        }

        public void Save()
        {
            string directory = "Users";
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string path = $"{directory}/{Login}.json";
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }
        //public static void Save(List<User> users)
        //{
        //    var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
        //    File.WriteAllText("users.json", json);
        //}
        public static User Load(string login)
        {
            string path = $"Users/{login}.json";
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<User>(json);
            }
            return null;
        }

        public void ChangePassword(string newPassword)
        {
            if (IsPasswordValid(newPassword))
            {
                Password = newPassword;
                Save();
                Console.WriteLine("Password changed successfully!");
            }
            else
            {
                Console.WriteLine("The password does not meet the requirements!");
            }
        }

        public void ChangeBirthDate(DateTime newBirthDate)
        {
            BirthDate = newBirthDate;
            Save(); 
            Console.WriteLine("Date of birth successfully changed!");   
        }
        public bool CheckPassword(string inputPassword)
        {
            return Password == inputPassword;
        }
    }
}
