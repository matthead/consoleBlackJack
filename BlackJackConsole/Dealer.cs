using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsole
{
    class Dealer
    {
        public Dealer(Models.Table dealerTable)
        {
            this.table = dealerTable;
            hand = new Models.Hand();
        }
        public void DealMainRound()
        {
            isInMiddleOfDeal = true;
            //makes sure there are people at the table and that the shoe did not end
            if (table.players.Count > 0 && !table.shoe.ShoeEnded())
            {                
                    //loop the players twice so each player will have 2 cards
                for (int index = 0; index < 2; index++)
                {
                    foreach (Models.Player player in table.players)
                    {

                        player.hand.cards.Add(table.shoe.GetTopCard());
                    }
                    //add cards to dealer hands also;
                    this.hand.cards.Add(table.shoe.GetTopCard());
                }
            }
        }
        public Models.Hand hand { get; private set; }
        public bool isInMiddleOfDeal { get; private set; }
        Models.Table table;
        private Shoe shoe;
        


    }
}
