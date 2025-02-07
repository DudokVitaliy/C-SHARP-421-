using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Dictionary_HW
{
    internal class Player
    {
        public string Name { get; set; }
        public List<Card> player_cards;
        public Player(string name)
        {
            Name = name;
            player_cards = new List<Card>();
        }
        public void PrintCards()
        {
            Console.WriteLine($"\t{Name} Cards:");
            foreach (Card card in player_cards)
            {
                if (card.Suit == Suits.Diamonds || card.Suit == Suits.Hearts)
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (card.Suit == Suits.Clubs || card.Suit == Suits.Spades)
                    Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(card);
                Console.ResetColor();
            }
        }
        public void AddCard(Card card)
        {
            player_cards.Add(card);
        }
        public Card PlayCard()
        {
            Card playedCard = player_cards[0];
            player_cards.RemoveAt(0);
            return playedCard;
        }
        public void CollectCards(List<Card> trophy)
        {
            player_cards.AddRange(trophy);
        }
    }
}
