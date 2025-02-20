using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _00_Finall_Work
{
    public class QuizResult
    {
        public string Username { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }

        public QuizResult(string username, int score, DateTime date)
        {
            Username = username;
            Score = score;
            Date = date;
        }
    }
}
