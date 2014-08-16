using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models
{
    public class Hand
    {
        public Hand()
        {
            hand = new List<Card>();
        }
        public List<Card> hand { get; private set; }
    }
}