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
        Random random = new Random();

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

        public IEnumerable<Card> Shuffle()
        {
            IOrderedEnumerable<Card> shuffled = cardDeck.OrderBy(Card => random.Next());
            var firstTwoCards = shuffled.Take(2);
            foreach (var card in firstTwoCards)
            {
                Console.WriteLine("First Two Cards: {0} {1}", card.Suit, card.Value);
            }
            foreach (var card in shuffled)
            {
                Console.WriteLine("ShuffledCard: {0} {1}", card.Suit, card.Value);
            }
            return shuffled;        
        }

        /*
        public IEnumerable<Card> CheckForBadCards()
        {
            int index = 0;
            
            //IOrderedEnumerable<Card> shuffled = cardDeck.OrderBy(Card => random.Next());
            var firstTwoCards = shuffled.Take(2);
            // var lastTwoCards = cardDeck.GetRange(cardDeck.Count - 2, 2);
            foreach(var card in firstTwoCards)
            {
                Console.WriteLine("First Two Cards: {0} {1}", card.Suit, card.Value);
            }
            /*
            foreach(var card in lastTwoCards)
            {
                Console.WriteLine("Last Two Cards: {0} {1}", card.Suit, card.Value);
            }
            */

            /*
            foreach (var card in shuffled)
            {
                card.GetRange(0, 2);
                Console.WriteLine("ShuffledCard: {0} {1}", card.Suit, card.Value);
                index++;
            }
            return shuffled;
            
            return firstTwoCards;
            
        }
         */
        
        
    }
}
