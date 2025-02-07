using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dictionary_HW
{
    internal class Game
    {
        List<Player> players;
        List<Card> deck;
        public Game(List<Player> players)
        {
            this.players = players;
            
            CreateDeck();
            ShufflingDeck();
            DealCards();
        }
        private void CreateDeck()
        {
            string[] types = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Suits[] suits = { Suits.Spades, Suits.Diamonds, Suits.Clubs, Suits.Hearts };

            deck = new List<Card>();
            for (int i = 0; i < types.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    deck.Add(new Card(types[i], suits[j]));
                }
            }
        }
        private void ShufflingDeck()
        {
            List <Card> rand_deck = new List<Card>();
            int index;
            for (int i = 35; i >= 0; i--)
            {
                index = new Random().Next(0, i);
                rand_deck.Add(deck[index]);
                deck.RemoveAt(index);
            }
            deck = rand_deck;
        }
        private void DealCards()
        {
            int index = 0;
            for (int i = 0; i < deck.Count; i++)
            {
                players[index].AddCard(deck[i]);
                index = (index + 1) % players.Count;
            }
            for (int j = 0; j < players.Count; j++)
            {
                players[j].PrintCards();
            }
        }
        private Player CheckWinner(List<Card> PlayedCards)
        {
            Card bestCard = PlayedCards.MaxBy(c => c.Rank())!;
            Player winner = players[PlayedCards.IndexOf(bestCard)];
            return winner;
        }
        private void WhoIsOut()
        {
            for (int i = players.Count - 1; i >= 0; i--)
            {
                if (players[i].player_cards.Count == 0)
                {
                    Console.WriteLine($"\tPlayer {players[i].Name} is out of the game!");
                    players.RemoveAt(i);
                }
            }
        }
        public void StartGame()
        {
            {
                Console.WriteLine("\t\tStart Game!\n");

                while (players.Count > 1)
                {
                    List<Card> playedCards = new List<Card>();

                    Console.WriteLine("\n--- Round ---");

                    for (int i = 0; i < players.Count; i++)
                    {
                        Card playedCard = players[i].PlayCard();
                        playedCards.Add(playedCard);
                        Console.Write($"{players[i].Name,10} put "); playedCard.PrintOne() ; Console.WriteLine($"\t\tscore: {players[i].player_cards.Count}");
                    }

                    Player winner = CheckWinner(playedCards);

                    Console.WriteLine($"Winner {winner.Name} and he takes {playedCards.Count} cards!\n");
                    winner.CollectCards(playedCards);
                    WhoIsOut();

                    Thread.Sleep(500);
                }

                Player FinalWinner = players.First();
                Console.WriteLine($"\n {FinalWinner.Name} is Winner!!!");
            }
        }
        public void PrintDeck()
        {
            foreach (Card card in deck)
            {
                if (card.Suit == Suits.Diamonds || card.Suit == Suits.Hearts)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (card.Suit == Suits.Clubs || card.Suit == Suits.Spades)
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(card);
                Console.ResetColor();
            }
        }

    }
}
