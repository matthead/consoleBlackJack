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
            cards = new List<Card>();
        }
        public List<Card> cards { get; private set; }
    }
}