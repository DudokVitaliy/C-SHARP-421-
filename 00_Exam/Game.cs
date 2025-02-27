using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Formats.Asn1.AsnWriter;

namespace _00_Exam
{
    internal class Game
    {
        private Hero hero;
        private List<Enemy> enemyList;
        private char[,] map;
        private int heroX, heroY;
        private int shopX, shopY;
        private Random random = new Random();

        private const int MapSize = 20;
        private const char Empty = '.';
        private const char HeroIcon = 'H';
        private const char EnemyIcon = 'E';
        private const char ShopIcon = 'S';
        private const char ResourceIcon = 'R';

        public Game()
        {
            Menu();
        }

        public void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t===== GAME MENU =====");
                Console.WriteLine("\t1 - Start New Game");
                Console.WriteLine("\t2 - Load Game");
                Console.WriteLine("\t0 - Exit");
                Console.Write("\t -> ");
                string input = Console.ReadLine();

                if (input == "1")
                {

                    StartNew();
                }
                else if (input == "2")
                {
                    LoadGame();
                    Thread.Sleep(1000);
                }
                else if (input == "0") break;
            }
        }

        public void StartNew()
        {
            Console.Clear();
            Console.Write("\tEnter your hero name: ");
            string name = Console.ReadLine();
            hero = new Hero(name, 10, 100);
            enemyList = GenerateEnemies();
            GenerateMap();
            GameLoop();
        }

        public void LoadGame()
        {
            try
            {
                string json = File.ReadAllText("savegame.json");
                GameState state = JsonSerializer.Deserialize<GameState>(json);

                if (state != null)
                {
                    hero = state.Hero;
                    enemyList = state.Enemies ?? new List<Enemy>();

                    Console.WriteLine("\tGame loaded successfully!");
                    Thread.Sleep(1000);

                    GenerateMap();

                    if (state.EnemyPositions != null && state.EnemyPositions.Count == enemyList.Count)
                    {
                        for (int i = 0; i < enemyList.Count; i++)
                        {
                            var (x, y) = state.EnemyPositions[i];
                            map[x, y] = EnemyIcon;
                        }
                    }
                   GameLoop();
                }
                else
                {
                    Console.WriteLine("\tFailed to load game: Deserialization returned null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\tError loading game: " + ex.Message);
            }
        }

        public void SaveGame()
        {
            List<(int, int)> enemyPositions = new List<(int, int)>();

            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (map[i, j] == EnemyIcon)
                    {
                        enemyPositions.Add((i, j));
                    }
                }
            }

            GameState state = new GameState(hero, enemyList, enemyPositions);
            string json = JsonSerializer.Serialize(state, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText("savegame.json", json);
            Console.WriteLine("\tGame saved successfully!");
        }

        private void GameLoop()
        {
            while (hero.Health > 0)
            {
                Console.Clear();
                Console.WriteLine(hero);
                DrawMap();
                Console.WriteLine("\nUse W/A/S/D to move. Press Q to save and exit.");
                Console.Write("\t -> ");
                char move = Console.ReadKey().KeyChar;

                if (move == 'q' || move == 'Q')
                {
                    SaveGame();
                    Thread.Sleep(1000);
                    return;
                }

                MoveHero(move);
                Thread.Sleep(500);
            }

            Console.WriteLine("\tGame Over! Your hero has fallen...");
            File.Delete("savegame.json");
        }

        private void GenerateMap()
        {
            map = new char[MapSize, MapSize];
            HashSet<(int, int)> usedPositions = new HashSet<(int, int)>();

            for (int i = 0; i < MapSize; i++)
                for (int j = 0; j < MapSize; j++)
                    map[i, j] = Empty;

            do
            {
                heroX = random.Next(MapSize);
                heroY = random.Next(MapSize);
            } while (usedPositions.Contains((heroX, heroY)));

            map[heroX, heroY] = HeroIcon;
            usedPositions.Add((heroX, heroY));

            foreach (var enemy in enemyList)
            {
                int x, y;
                do
                {
                    x = random.Next(MapSize);
                    y = random.Next(MapSize);
                } while (usedPositions.Contains((x, y)));

                map[x, y] = EnemyIcon;
                usedPositions.Add((x, y));
            }
            int countRes = new Random().Next(5,11);
            for (int i = 0; i < countRes; i++)
            {
                int x, y;
                do
                {
                    x = random.Next(MapSize);
                    y = random.Next(MapSize);
                } while (usedPositions.Contains((x, y)));

                map[x, y] = ResourceIcon;
                usedPositions.Add((x, y));
            }
            do
            {
                shopX = random.Next(MapSize);
                shopY = random.Next(MapSize);
            } while (usedPositions.Contains((shopX, shopY)));

            map[shopX, shopY] = ShopIcon;
        }

        private void DrawMap()
        {
            for (int i = 0; i < MapSize; i++)
            {
                for (int j = 0; j < MapSize; j++)
                {
                    if (map[i, j] == HeroIcon)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (map[i, j] == EnemyIcon)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (map[i, j] == ShopIcon)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else if (map[i, j] == ResourceIcon)
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    else
                        Console.ForegroundColor = ConsoleColor.Gray;

                    Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        private void MoveHero(char direction)
        {
            int newX = heroX, newY = heroY;

            switch (direction)
            {
                case 'w': case 'W': newX--; break;
                case 's': case 'S': newX++; break;
                case 'a': case 'A': newY--; break;
                case 'd': case 'D': newY++; break;
                default: return;
            }

            if (newX < 0 || newX >= MapSize || newY < 0 || newY >= MapSize)
                return;

            char nextTile = map[newX, newY];

            if (nextTile == EnemyIcon)
            {
                Console.WriteLine("\n\tYou encountered an enemy!");
                Thread.Sleep(1000);

                Enemy enemy = enemyList[random.Next(enemyList.Count)];
                bool victory = hero.Fight(enemy);

                if (victory)
                {
                    Console.WriteLine("\tYou won the battle!");
                    map[newX, newY] = Empty;
                }
                else
                {
                    Console.WriteLine("\tYou lost...");
                    return;
                }
            }
            else if (nextTile == ResourceIcon)
            {
                Console.WriteLine("\n\tYou found resources!");
                hero.ExtractResources();
                map[newX, newY] = Empty;
                Thread.Sleep(1000);
            }
            else if (nextTile == ShopIcon)
            {
                Console.WriteLine("\n\tYou found a shop!");
                Shop.GoShop(hero);
            }

            if (heroX == shopX && heroY == shopY)
            {
                map[heroX, heroY] = ShopIcon;
            }
            else
            {
                map[heroX, heroY] = Empty;
            }

            heroX = newX;
            heroY = newY;
            map[heroX, heroY] = HeroIcon;
        }

        private List<Enemy> GenerateEnemies()
        {
            return new List<Enemy>
            {
                new Monster("Goblin", 30, 5, 10),
                new Monster("Goblin", 30, 5, 10),
                new Monster("Goblin", 30, 5, 10),
                new Monster("Orc", 50, 8, 15),
                new Monster("Orc", 50, 8, 15),
                new Monster("Orc", 50, 8, 15),
                new Boss("Dragon", 100, 15, 50, 10)
            };
        }
    }
}
