using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models
{
    public class Player
    {
        public int wealth { get; private set; }
        public string password { get; private set; }
        public List<Hand> hand { get; private set; }
        public int currentBet { get; private set; }
        public Player()
        {
            hand = new List<Hand>();
            //have to add a new instance which is needed because dealingmainround will explicitly use hand[0] 
            hand.Add(new Hand());
        }
        private bool Validatebet(Table table)
        {
            if (currentBet < table.minBet || currentBet > table.maxBet)
            {
                return false;
            }
            return true;
        }
    }
}