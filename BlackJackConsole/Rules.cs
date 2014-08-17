using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    public class Rules
    {
        public int EvaluateTotal(Models.Hand hand)
        {
            int handTotal = 0;
            bool oneOfPlayersCardsIsAnAce = false;
            foreach (Models.Card card in hand.cards)
            {
                handTotal += (int)card._faceValue;
                if (card._faceValue == Models.FaceValue.ace)
                {
                    oneOfPlayersCardsIsAnAce = true;
                }
            }
            //Makes ace worth a total of 11. you only need to worry about one ace per hand to be worth 11
            if (handTotal + 10 <= 21 && oneOfPlayersCardsIsAnAce)
            {
                handTotal += 10;
            }
            return handTotal;
        }
        public bool IsHandBusted(Models.Hand hand)
        {
            return EvaluateTotal(hand) > 21;
        }
        public bool IsHandSplitablle(Models.Hand hand)
        {
            if (hand.cards.Count == 2)
            {
                if (hand.cards[0]._faceValue == hand.cards[1]._faceValue)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsHandDoubleable(Models.Hand hand)
        {
            return hand.cards.Count == 2 && EvaluateTotal(hand) < 20;
        }
        public bool IsHandBlackJack(Models.Hand hand)
        {
            if (hand.cards.Count() == 2)
            {
                return EvaluateTotal(hand) == 21;
            }
            return false;
        }
    }
}