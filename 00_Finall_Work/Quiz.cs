using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _00_Finall_Work
{
    internal class Quiz
    {
        public string Category { get; set; }
        public List<Question> Questions { get; set; }

        public Quiz(string category, List<Question> questions)
        {
            Category = category;
            Questions = questions;
        }
        public Quiz(string category)
        {
            Category=category;
            Questions = new List<Question>();
        }
        public Quiz()
        {
            Category = string.Empty;
            Questions = new List<Question>();
        }
        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }
        public int StartQuiz()
        {
            int score = 0;

            foreach (var question in Questions)
            {
                question.PrintQuestion();

                List<int> userAnswers = new List<int>();
                Console.WriteLine("Enter the numbers of your answers (comma (,) separated): ");
                var input = Console.ReadLine()?.Split(',').Select(i => int.Parse(i.Trim()) - 1).ToList();

                if (input != null)
                {
                    userAnswers = input;
                }

                if (question.IsCorrect(userAnswers))
                {
                    score++;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }

                Console.WriteLine();
            }
            return score;
        }
        public int StartQuiz(string username)
        {
            int score = 0;

            foreach (var question in Questions)
            {
                Console.WriteLine(question.Text);
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                }

                Console.WriteLine("Enter the numbers of the correct answers (comma separated): ");
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

            // Після проходження вікторини зберігаємо результат
            var results = LoadResults(Category);
            results.Add(new QuizResult(username, score, DateTime.Now));
            results = results.OrderByDescending(r => r.Score).Take(20).ToList();  // Топ-20
            SaveResults(Category, results);

            return score;
        }
        public static void SaveResults(string category, List<QuizResult> results)
        {
            var json = JsonSerializer.Serialize(results, new JsonSerializerOptions { WriteIndented = true });
            var path = $"{category}_results.json";
            File.WriteAllText(path, json);
        }
        public static List<QuizResult> LoadResults(string category)
        {
            var path = $"{category}_results.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<QuizResult>>(json) ?? new List<QuizResult>();
            }
            return new List<QuizResult>();
        }
        public static void ViewTopResults(string category)
        {
            var results = LoadResults(category);
            if (results.Any())
            {
                Console.WriteLine($"Top results for {category} quiz:");
                foreach (var result in results)
                {
                    Console.WriteLine($"\t{result.Username} :: {result.Score} points :: {result.Date}");
                }
            }
            else
            {
                Console.WriteLine("No results yet.");
            }
        }
    }
}
