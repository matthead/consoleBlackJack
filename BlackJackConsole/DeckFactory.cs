using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    public static class DeckFactory
    {

        public static List<Models.Card> BuildDeck()
        {
            if (deck == null)
            {
                deck = new List<Models.Card>();
            }
            foreach (Models.Suit suit in Enum.GetValues(typeof(Models.Suit)))
            {
                foreach (Models.FaceValue faceValue in Enum.GetValues(typeof(Models.FaceValue)))
                {
                    deck.Add(new Models.Card(suit, faceValue));
                }
            }
            return deck;
        }
        public const int deckSize = 52;
        private static List<Models.Card> deck { get; set; }
    }
}