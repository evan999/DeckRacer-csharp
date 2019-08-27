using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRacer
{
    class Card
    {
        public int Suit { get; set; }
        public int Value { get; set; }
        

        public Card(int suit, int value)
        {
            Suit = suit;
            Value = value ;
        }

        /*
        public static List<string> ValidSuits()
        {
            var cardSuitsValid = new List<string> { "Hearts", "Spades", "Diamonds", "Clubs" };
            return cardSuitsValid;
        }
        */
    }
}
