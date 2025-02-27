using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Exam
{
    internal class GameState
    {
        public Hero Hero { get; set; }
        public List<Enemy> Enemies { get; set; }
        public List<(int X, int Y)> EnemyPositions { get; set; }

        public GameState() { }

        public GameState(Hero hero, List<Enemy> enemies, List<(int, int)> enemyPositions)
        {
            Hero = hero;
            Enemies = enemies;
            EnemyPositions = enemyPositions;
        }
    }
}
