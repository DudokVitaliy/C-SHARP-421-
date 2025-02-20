using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _00_Finall_Work
{
    public class QuizApp
    {
        public static List<Quiz> Quizzes;
        public static List<User> Users;

        static QuizApp()
        {
            Quizzes = new List<Quiz>();
            Users = new List<User>();
            InitializeQuizzes();
            LoadUsers();
        }
        public static void LoadUsers()
        {
            var directory = "Users";
            if (Directory.Exists(directory))
            {
                var userFiles = Directory.GetFiles(directory, "*.json");
                var users = new List<User>();

                foreach (var file in userFiles)
                {
                    var userJson = File.ReadAllText(file);
                    var user = JsonSerializer.Deserialize<User>(userJson);
                    if (user != null)
                    {
                        users.Add(user);
                    }
                }

                Users = users;
            }
            else
            {
                Users = new List<User>();
            }
        }

        public static void InitializeQuizzes()
        {
            //QuizEditor.Base(); // - розкоментуйте преред першим запуском щоб зберігся файл із базою тестів
            Quizzes = QuizEditor.LoadQuizzes();

            if (Quizzes == null || Quizzes.Count == 0)
            {
                Quizzes = new List<Quiz>();
            }

        }

        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("\t\tMain Menu:");
                Console.WriteLine("\t1 - Login");
                Console.WriteLine("\t2 - Register");
                Console.WriteLine("\t3 - Admin Menu (Editor)");
                Console.WriteLine("\t0 - Exit");
                Console.Write("\t--> ");
                try
                {
                    int choice = int.Parse(Console.ReadLine()!);
                    if (choice == 0)
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter your login: ");
                            string login = Console.ReadLine()!;
                            Console.WriteLine("Enter your password: ");
                            string password = Console.ReadLine()!;

                            var user = Users.FirstOrDefault(u => u.Login == login && u.Password == password);
                            if (user != null)
                            {
                                Console.WriteLine($"Welcome, {user.Login}!");
                                UserMenu(user);
                            }
                            else
                            {
                                Console.WriteLine("Invalid login or password!");
                            }
                            break;

                        case 2:
                            try
                            {
                                Register();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Registration Error! Try Again!");
                            }

                            break;
                        case 3:
                            Console.WriteLine("Enter admin password:");
                            if (Console.ReadLine() == "admin")
                            {
                                QuizEditor.Start();
                            }
                            else
                            {
                                Console.WriteLine("Wrong password!");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Try Again!");
                }   
            }
        }
        public static void Register()
        {
            Console.WriteLine("Enter your desired login: ");
            string login = Console.ReadLine()!;

            if (Users.Any(u => u.Login == login))
            {
                Console.WriteLine("A user with this login already exists.");
                return;
            }
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine()!;
            

            Console.WriteLine("Enter your birth date (YYYY-MM-DD): ");
            DateTime birthDate;
            if (!DateTime.TryParse(Console.ReadLine(), out birthDate))
            {
                Console.WriteLine("Invalid birth date format.");
                return;
            }

            var newUser = User.Register(login, password, birthDate);
            if (newUser != null)
            {
                Users.Add(newUser);
                //User.Save(Users);
                Console.WriteLine("Registration successful! You can now log in.");
            }
            else
            {
                Console.WriteLine("Error! Try Again!");
            }
            
        }
        public static void UserMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("\t\tUser Menu:");
                Console.WriteLine("\t1 - Start a quiz");
                Console.WriteLine("\t2 - Start a Mixed Quiz");
                Console.WriteLine("\t3 - View top results");
                Console.WriteLine("\t4 - Change password");
                Console.WriteLine("\t5 - Change birth date");
                Console.WriteLine("\t0 - Logout");
                Console.Write("\t--> ");

                int choice = int.Parse(Console.ReadLine()!);

                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Select a quiz category:");
                        for (int i = 0; i < Quizzes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {Quizzes[i].Category}");
                        }
                        int quizChoice = int.Parse(Console.ReadLine()!) - 1;

                        if (quizChoice >= 0 && quizChoice < Quizzes.Count)
                        {
                            var quiz = Quizzes[quizChoice];
                            int score = quiz.StartQuiz(user.Login);
                            Console.WriteLine($"Your score: {score}/{quiz.Questions.Count}");
                        }
                        break;


                    case 2:
                        StartMixedQuiz(user);
                        break;
                    case 3:
                        Console.WriteLine("Select a quiz category to view top results:");
                        for (int i = 0; i < Quizzes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {Quizzes[i].Category}");
                        }
                        int resultChoice = int.Parse(Console.ReadLine()!) - 1;

                        if (resultChoice >= 0 && resultChoice < Quizzes.Count)
                        {
                            var quiz = Quizzes[resultChoice];
                            Quiz.ViewTopResults(quiz.Category);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter new password: ");
                        string newPassword = Console.ReadLine()!;
                        user.ChangePassword(newPassword);
                        //User.Save(Users);
                        user.Save();
                        break;

                    case 5:
                        Console.WriteLine("Enter new birth date (YYYY-MM-DD): ");
                        DateTime newBirthDate;
                        if (DateTime.TryParse(Console.ReadLine(), out newBirthDate))
                        {
                            user.ChangeBirthDate(newBirthDate);
                            //User.Save(Users);
                            user.Save();
                        }
                        else
                        {
                            Console.WriteLine("Invalid date format!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        public static void StartMixedQuiz(User user)
        {
            var allQuestions = Quizzes.SelectMany(q => q.Questions).ToList();
            var random = new Random();
            var mixedQuestions = allQuestions.OrderBy(q => random.Next()).Take(20).ToList();

            int score = 0;
            foreach (var question in mixedQuestions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                }

                Console.WriteLine("Enter the numbers of the correct answers (comma(,) separated): ");
                var input = Console.ReadLine()?.Split(',').Select(i => int.Parse(i.Trim()) - 1).ToList();

                if (input != null && question.IsCorrect(input))
                {
                    score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }
            }

            Console.WriteLine($"Your score: {score}/{mixedQuestions.Count}");
        }
    }
}

