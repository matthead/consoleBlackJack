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
            foreach (Models.Card card in hand.hand)
            {
                handTotal += (int)card.faceValue;
            }
            return handTotal;
        }
        public bool IsHandBusted(Models.Hand hand)
        {
            return EvaluateTotal(hand) > 21;
        }
        public bool IsHandSplitablle(Models.Hand hand)
        {
            if (hand.hand.Count == 2)
            {
                if (hand.hand[0].faceValue == hand.hand[1].faceValue)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsHandDoubleable(Models.Hand hand)
        {
            return hand.hand.Count == 2 && EvaluateTotal(hand) < 20;
        }
    }
}