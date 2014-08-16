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
            //used for first instance of shoe populates shoe list and initializes usedCard list
            if (shoe == null)
            {
                shoe = new List<Models.Card>();
                List<Models.Card> oneStandardDeck = DeckFactory.BuildDeck();
                FillShoe(ref oneStandardDeck);
                usedCards = new List<Models.Card>();
            }
            // if new game then puts the cards back into the shoe and clears the usedcards. this could be a problem if references, but cannot test 
            else
            {
                AddUsedCardsBackIntoShoe();
                usedCards.Clear();
            }
            SetCutCardPosition();
            //ShuffleShoe(); 
        }
        public Models.Card GetTopCard()
        {
            usedCards.Add(shoe[0]);
            shoe.RemoveAt(0);
            return usedCards.Last();
        }
        private void ShuffleShoe()
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
            //testing stupid reference 
            /*Console.WriteLine("deck " + oneStandardDeck[0]);
            shoe[0] = shoe[10];
            Console.WriteLine("shoe " + shoe[0]);
            Console.WriteLine("deck " + oneStandardDeck[0]);*/
        }
        private void SetCutCardPosition()
        {
            cutCardPosition = Convert.ToInt32(DeckFactory.deckSize * .8);
        }
        public bool ShoeEnded()
        {
            return usedCards.Count > cutCardPosition;
        }
        private List<Models.Card> shoe {get; set; }
        private int numberOfDecks { get; set; }
        private List<Models.Card> usedCards;
        private int cutCardPosition { get; set; }
    }
}