using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole.Models
{
    class Table : Interfaces.ITable
    {
        public List<Player> players { get; private set; }
        public int minBet { get; private set; }
        public int maxBet { get; private set; }
        public int maxNumberOfPlayers { get; private set; }
        public Rules rule { get; private set; }
        public Dealer dealer { get; private set; }
        public Shoe shoe { get; private set; }
        public Table()
        {
            // new table started
            players = new List<Player>();
            dealer = new Dealer(this);
            shoe = new Shoe();
            this.maxNumberOfPlayers = 6;
            rule = new Rules();
            this.minBet = 10;
            this.maxBet = 2500;
        }        
        public bool AddPlayerToTable(Player newPlayer)
        {
            if (SpacesLeftAtTable() >0)
            {
                players.Add(newPlayer);
                return true;
            }
            return false;
        }
        //test function
        public void Start()
        {
            dealer.DealMainRound();
        }
        public bool RemovePlayer(Player playerLeaving)
        {
            return players.Remove(playerLeaving);
        }
        private int SpacesLeftAtTable()
        {
            return maxNumberOfPlayers - players.Count();
        }
        private bool Validbet()
        {
            foreach (Player player in players)
            {
                if (player.currentBet < minBet || player.currentBet > maxBet)
                {
                    return false;
                }
            }
            return true;
        }       
    }
}
