using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace _26_Dictionary_HW
{
    internal class Card
    {
        public string Type { get; set; }
        public Suits Suit { get; set; }
        public Card(string type, Suits suit)
        {
            Type = type;
            Suit = suit;
        }
        public int Rank()
        {
            switch (Type)
            {
                case "6": return 6;
                case "7": return 7;
                case "8": return 8;
                case "9": return 9;
                case "10": return 10;
                case "J": return 11;
                case "Q": return 12;
                case "K": return 13;
                case "A": return 14;
                default:
                    return 0;
            }
        }
        public void PrintOne()
        {
            if (Suit == Suits.Diamonds || Suit == Suits.Hearts)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (Suit == Suits.Clubs || Suit == Suits.Spades)
                Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{Type} {Suit.ToChar()}");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return $"{Type} {Suit.ToChar()}";
        }


    }
}
