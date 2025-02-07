
namespace _26_Dictionary_HW
{
    public enum Suits : int
    {
        Hearts = '\u2665',
        Diamonds = '\u2666',
        Clubs = '\u2663',
        Spades = '\u2660'

    }
    public static class SuitsExtensions
    {
        public static char ToChar(this Suits suit)
        {
            return (char)suit;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Player player1 = new Player("Ivan");
            Player player2 = new Player("Kolya");
            Player player3 = new Player("Dima");
            Player player4 = new Player("Yarik");
            Player player5 = new Player("Vitalya");
            Player player6 = new Player("Vasya");
            Game game = new Game(new List<Player>() { player1, player2, player3, player4, player5, player6});
            game.StartGame();
            //game.PrintDeck();

        }
    }
}
