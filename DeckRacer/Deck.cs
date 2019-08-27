using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckRacer
{
    class Deck
    {
        // private Card[] cards;
        // public List<Card> Cards { get; set; }
        List<Card> cardDeck = new List<Card>();

        public Deck()
        {
            // int cardsInDeck = 28;
            int maxSuit = 4;
            int maxValue = 8;
            cardDeck = new List<Card>();

            for (int cardValue = 1; cardValue < maxValue; cardValue++)
            {
                for (int suitValue = 0; suitValue < maxSuit; suitValue++)
                {
                    cardDeck.Add(new Card(suitValue, cardValue));                                  
                }
            }

            foreach (var card in cardDeck)
            {
                Console.WriteLine("Card: {0} {1}", card.Suit, card.Value);
            }
        }

        public Card Shuffle()
        {
            
        }
        
        
    }
}
