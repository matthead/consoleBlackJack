using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    public class Shoe : Models.Interfaces.IShoe
    {
        public Shoe(int numberOfDecks=1)
        {
            this.numberOfDecks = numberOfDecks;
            if (shoe == null)
            {
                shoe = new List<Models.Card>();
            }
            List<Models.Card> oneStandardDeck = DeckFactory.BuildDeck();
            FillShoe(ref oneStandardDeck);
            usedCards = new List<Models.Card>();
            SetLengthOfPlayableCardsForShoe();
            Shuffle();
        }
        public Models.Card GetTopCard()
        {
            usedCards.Add(shoe[0]);
            shoe.RemoveAt(0);
            return usedCards.Last();
        }
        private void Shuffle()
        {
            Random rand = new Random();
            int n = shoe.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Models.Card  temp= shoe[k];
                shoe[k] = shoe[n];
                shoe[n] = temp;
            }
        }        
        private void AddUsedCardsBackIntoShoe()
        {
            shoe.AddRange(usedCards);
        }
        private void FillShoe(ref List<Models.Card> oneStandardDeck)
        {
            for (int numberOfDeckIndex = 0; numberOfDeckIndex < numberOfDecks; numberOfDeckIndex++)
            {
                shoe.AddRange(oneStandardDeck);
            }
        }
        private void SetLengthOfPlayableCardsForShoe()
        {
            sizeOfPlayableCards = Convert.ToInt32(DeckFactory.deckSize * .8);
        }
        private List<Models.Card> shoe {get; set; }
        private int numberOfDecks { get; set; }
        private List<Models.Card> usedCards;
        private int sizeOfPlayableCards { get; set; }
    }
}