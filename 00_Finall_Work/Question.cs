using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Finall_Work
{
    internal class Question
    {
        public string Text { get; set; }
        public List<string> Answers { get; set; }
        public List<int> CorrectAnswers { get; set; }

        public Question(string text, List<string> answers, List<int> correctAnswers)
        {
            Text = text;
            Answers = answers;
            CorrectAnswers = correctAnswers;
        }

        public bool IsCorrect(List<int> answers)
        {
            return CorrectAnswers.SequenceEqual(answers);
        }

        public void PrintQuestion()
        {
            Console.WriteLine(Text);
            for (int i = 0; i < Answers.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {Answers[i]}");
            }
        }
    }
}
